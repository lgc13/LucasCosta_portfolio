package com.revature.dao;

import java.util.ArrayList;

import com.revature.pojo.RebsObj;

public interface RebsDAO {

		public void createReimbursement(RebsObj reb);
		public RebsObj selectReimbursementById(int id);
		public ArrayList<RebsObj> selectReimbursements();
		public ArrayList<RebsObj> selectEmployeeReimbursementsById(int id);
		public RebsObj updateReimbursement(RebsObj reb);
		public void approvingOrDecliningRequest(int id, int resolver_id, int status);
		public void deleteReimbursementById(int id);
	
}
