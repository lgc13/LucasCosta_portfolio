package com.revature.dao;

import static com.revature.util.CloseStreams.close;

import java.io.IOException;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Timestamp;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;

import javax.servlet.http.Part;

import com.revature.pojo.RebsObj;
import com.revature.util.ConnectionUtil;

public class RebsDAOImpl implements RebsDAO {

	@Override
	public void createReimbursement(RebsObj reb) {
		
		// creating PS which will run queries
		PreparedStatement ps = null;
		PreparedStatement ps2 = null;
		ResultSet rs = null;  // creating a resultSet which will save any queries
		
		// looks in util/ConnectionUtil.java and saves the url, username and password to "conn"
		try(Connection conn = ConnectionUtil.getConnection();){ 
			
			//int rebs_id = reb.getRebsId(); // REBS_ID IS AUTO INCREMENTING
			int user_id = reb.getUserId();
			//int man_id = reb.getManagerId(); // not needed
			int rebs_type = reb.getRebsType();
			int rebs_status = reb.getRebsStatus();
			double rebs_amount = reb.getRebsAmount();
			String rebs_description = reb.getRebsDescription();
			// Blob rebs_attachments
			Timestamp time_submitted = new Timestamp(System.currentTimeMillis());		
			// Timestamp time_resolved
			
			Part rebs_photo = reb.getRebsPhoto();
			
			
			DateFormat dateFormat = new SimpleDateFormat("dd-MMM-YY hh:mm:ss.SSSSSSSSS");
			dateFormat.format(time_submitted);
			reb.setTimeSubmitted(time_submitted);
			System.out.println("TIME STAMP IN DAO: " + time_submitted);
			
			String sql2 = "SELECT REBS_SEQ.nextval FROM DUAL"; // trying to get the next table value (for id #)
			ps2 = conn.prepareStatement(sql2);  // uses connection to send string as a prepared statement
			rs = ps2.executeQuery();
			
			while (rs.next())  // goes through all query results (in this case, we should only have 1)
			{
				// get first column of rs, then set it ==
				reb.setRebsId(rs.getInt(1));  
				
			}
			int rebs_id = reb.getRebsId(); // setting rebs_id to the the rebs_seq value
			
			// you can put this string 'sql' into multiple lines by adding +, and having everything within ""
			// this sql line will be ran on SQL
			String sql = "INSERT INTO ERS_REIMBURSEMENTS(rebs_id, user_id_author, user_id_resolver, "
					+ "rebs_type, rebs_status, rebs_amount, rebs_description, rebs_receipt, "
					+ "rebs_submitted, rebs_resolved) " 
					+ "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
					//+ "RETURNING rebs_id INTO ?";
			
			// creating prepared statement
			ps = conn.prepareStatement(sql);  // uses connection to send string as a prepared statement
			ps.setInt(1, rebs_id);   // REBS_ID IS AUTO INCREMENTING
			ps.setInt(2, user_id);
			ps.setString(3, null);
			ps.setInt(4, rebs_type);
			ps.setInt(5, rebs_status);
			ps.setDouble(6, rebs_amount);
			ps.setString(7, rebs_description);
			//ps.setString(8, null); this is the attachment
			
			try {
				// size must be converted to int otherwise it results in error
				ps.setBinaryStream(8, rebs_photo.getInputStream(), (int)  rebs_photo.getSize());
			} catch (IOException e) {
				e.printStackTrace();
			}
			ps.setTimestamp(9, time_submitted);
			ps.setString(10, null);
			//ps.setInt(11, rebs_id);
			
			System.out.println("in DAO, rebs_id: " + rebs_id);
			// rows affected
			int affected = ps.executeUpdate();
			System.out.println("Rows inserted: " + affected);
			
			
		}catch(SQLException e){
			e.printStackTrace();
		}finally{
			close(ps);
		}
		
		System.out.println("Created new reimbursement request!");

	}

	@Override
	public RebsObj selectReimbursementById(int id) {

		System.out.println("UDI - Selecting reb by id");
		
		RebsObj reb = null;
		PreparedStatement ps = null;  // creating another preparedStatement
		ResultSet rs = null;  // creating a resultSet which will save any queries
		
		try(Connection conn = ConnectionUtil.getConnection();){ // checking connection again
			
			System.out.println("UDI 2 - Going in connection");
			
			String sql = "SELECT * FROM ERS_REIMBURSEMENTS WHERE REBS_ID = ?";
			
			ps = conn.prepareStatement(sql); // running the sql and puts that's in a ps variable
			ps.setInt(1, id);  // replace the ?s id
						
			rs = ps.executeQuery();  // saves the query result in a rs variable
			
			while (rs.next())  // goes through all query results (in this case, we should only have 1)
			{
				reb = new RebsObj();
				// get first column of rs, then set it ==
				reb.setRebsId(rs.getInt(1));  
				reb.setUserId(rs.getInt(2));
				reb.setManagerId(rs.getInt(3));
				reb.setRebsType(rs.getInt(4));
				reb.setRebsStatus(rs.getInt(5));
				reb.setRebsAmount(rs.getInt(6));
				reb.setRebsDescription(rs.getString(7));
				reb.setRebsAttachments(rs.getBlob(8));
				reb.setTimeSubmitted(rs.getTimestamp(9));
				reb.setTimeResolved(rs.getTimestamp(10));	
			}
			
		}catch(SQLException e){
			e.printStackTrace();
		}finally{
			close(ps);
			close(rs);
		}
		//System.out.println("UDI 3 - Returning emp: " + emp.getUser_username());
		return reb;
	}

	@Override
	public ArrayList<RebsObj> selectReimbursements() {

		System.out.println("-----");
		System.out.println("This will get all reimbursements and put them in an ArrayList");
		
		ArrayList<RebsObj> rebArr = new ArrayList<>();
		RebsObj reb = null;
		
		PreparedStatement ps = null;  // creating another preparedStatement
		ResultSet rs = null;  // creating a resultSet which will save any queries
		
		try(Connection conn = ConnectionUtil.getConnection();){ // checking connection again
			
			System.out.println("Going in connection");
			
			String sql = "SELECT * FROM ERS_REIMBURSEMENTS ORDER BY REBS_ID"; // display them by REBS_ID order
			
			ps = conn.prepareStatement(sql); // running the sql and puts that's in a ps variable
						
			rs = ps.executeQuery();  // saves the query result in a rs variable
			
			while (rs.next())  // goes through all query results (in this case, we should only have 1)
			{
				// get first column of rs, then set it ==
				reb = new RebsObj();
				reb.setRebsId(rs.getInt(1));  
				reb.setUserId(rs.getInt(2));
				reb.setManagerId(rs.getInt(3));
				reb.setRebsType(rs.getInt(4));
				reb.setRebsStatus(rs.getInt(5));
				reb.setRebsAmount(rs.getInt(6));
				reb.setRebsDescription(rs.getString(7));
				reb.setRebsAttachments(rs.getBlob(8));
				reb.setTimeSubmitted(rs.getTimestamp(9));
				reb.setTimeResolved(rs.getTimestamp(10));
				
				rebArr.add(reb);  // add it to arraylist
			}
			
		}catch(SQLException e){
			e.printStackTrace();
		}finally{
			close(ps);
			close(rs);
		}
		System.out.println("Returning array: " + reb);
		
		return rebArr;
	}
	
	public ArrayList<RebsObj> selectEmployeeReimbursementsById(int id) {

		System.out.println("-----");
		System.out.println("This will get all reimbursements by one employee");
		
		ArrayList<RebsObj> rebArr = new ArrayList<>();
		RebsObj reb = null;
		
		PreparedStatement ps = null;  // creating another preparedStatement
		ResultSet rs = null;  // creating a resultSet which will save any queries
		
		try(Connection conn = ConnectionUtil.getConnection();){ // checking connection again
			
			System.out.println("Going in connection");
			
			String sql = "SELECT * FROM ERS_REIMBURSEMENTS WHERE USER_ID_AUTHOR = ? ORDER BY REBS_ID"; // display them by REBS_ID order
			
			ps = conn.prepareStatement(sql); // running the sql and puts that's in a ps variable
						
			ps.setInt(1, id);  // replace the ?s id
			
			rs = ps.executeQuery();  // saves the query result in a rs variable
			
			while (rs.next())  // goes through all query results (in this case, we should only have 1)
			{
				// get first column of rs, then set it ==
				reb = new RebsObj();
				reb.setRebsId(rs.getInt(1));  
				reb.setUserId(rs.getInt(2));
				reb.setManagerId(rs.getInt(3));
				reb.setRebsType(rs.getInt(4));
				reb.setRebsStatus(rs.getInt(5));
				reb.setRebsAmount(rs.getInt(6));
				reb.setRebsDescription(rs.getString(7));
				reb.setRebsAttachments(rs.getBlob(8));
				reb.setTimeSubmitted(rs.getTimestamp(9));
				reb.setTimeResolved(rs.getTimestamp(10));
				
				rebArr.add(reb);  // add it to arraylist
			}
			
		}catch(SQLException e){
			e.printStackTrace();
		}finally{
			close(ps);
			close(rs);
		}
		System.out.println("Returning array: " + reb);
		
		return rebArr;
	}

	@Override
	public RebsObj updateReimbursement(RebsObj reb) {

		System.out.println("UDI - updatting reimbursement request");
		
		PreparedStatement ps= null;
		ResultSet rs = null;
		
		try (Connection conn = ConnectionUtil.getConnection();) // checking that connection is proper
		{
			String sql = "UPDATE ERS_REIMBURSEMENTS SET "  // query to update reimbursement
					+ "user_id_author = ?, " 
					+ "user_id_resolver = ?, "
					+ "rebs_type = ?, "
					+ "rebs_status = ?, "
					+ "rebs_amount = ?, "
					+ "rebs_description = ?, "
					+ "rebs_receipt = ?, "
					+ "rebs_submitted = ?, "
					+ "rebs_resolved = ? "
					+ "WHERE rebs_id = ? ";		// where his id is what was given
			
			ps = conn.prepareStatement(sql); //  puts that sql statement in a ps variable
						
			ps.setInt(1, reb.getUserId());    
			ps.setInt(2, reb.getManagerId());
			ps.setInt(3, reb.getRebsType());
			ps.setInt(4, reb.getRebsStatus());
			ps.setDouble(5, reb.getRebsAmount());
			ps.setString(6, reb.getRebsDescription());
			ps.setBlob(7, reb.getRebsAttachments());
			ps.setTimestamp(8, reb.getTimeSubmitted());
			ps.setTimestamp(9, reb.getTimeResolved());
			ps.setInt(10, reb.getRebsId());
			
			rs = ps.executeQuery();  // saves the query result in a rs variable and execute it
			
		}catch(SQLException e){
			e.printStackTrace();
		}finally{
			close(ps);
			close(rs);
		}
		
		return reb;
	}

	@Override
	public void approvingOrDecliningRequest(int id, int resolver_id, int status) {

		System.out.println("UID - approving or declining request");
		
		PreparedStatement ps= null;
		ResultSet rs = null;
		
		Timestamp time_resolved = new Timestamp(System.currentTimeMillis());		
		DateFormat dateFormat = new SimpleDateFormat("dd-MMM-YY hh:mm:ss.SSSSSSSSS");
		dateFormat.format(time_resolved);
		
		System.out.println("Time for request approval/decline IN DAO: " + time_resolved);
		
		try (Connection conn = ConnectionUtil.getConnection();) // checking that connection is proper
		{
			String sql = "UPDATE ERS_REIMBURSEMENTS SET "  // query to update that user
					+ "user_id_resolver = ?, "
					+ "rebs_status = ?, "
					+ "rebs_resolved = ? "
					+ "WHERE rebs_id = ? ";		// where his id is what was given
			
			ps = conn.prepareStatement(sql); // running the sql and puts that's in a ps variable
						
			ps.setInt(1, resolver_id);    
			ps.setInt(2, status);
			ps.setTimestamp(3, time_resolved);
			ps.setInt(4, id);
			
			rs = ps.executeQuery();  // saves the query result in a rs variable and execute it
			
		}catch(SQLException e){
			e.printStackTrace();
		}finally{
			close(ps);
			close(rs);
		}

	}
	
	@Override
	public void deleteReimbursementById(int id) {

		System.out.println("UID - rejecting request");
		
		PreparedStatement ps= null;
		ResultSet rs = null;
		
		try (Connection conn = ConnectionUtil.getConnection();) // checking that connection is proper
		{
			String sql = "UPDATE ERS_REIMBURSEMENTS SET "  // query to update that user
					+ "rebs_status = ? "
					+ "WHERE rebs_id = ? ";		// where his id is what was given
			
			ps = conn.prepareStatement(sql); // running the sql and puts that's in a ps variable
						
			ps.setInt(1, 3);    // making 3, since that is inactive
			ps.setInt(2, id);
			
			rs = ps.executeQuery();  // saves the query result in a rs variable and execute it
			
		}catch(SQLException e){
			e.printStackTrace();
		}finally{
			close(ps);
			close(rs);
		}

	}

}
