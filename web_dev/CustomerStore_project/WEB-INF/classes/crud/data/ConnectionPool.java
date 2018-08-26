package crud.data;

import java.sql.*;
import javax.sql.DataSource;
import javax.naming.InitialContext;
import javax.naming.NamingException;

public class ConnectionPool
{
  private static ConnectionPool pool = null;
  private static DataSource dataSource = null;

  /*
  NOTES:

  blah blah blah















  important part:
  Hence begin with java:/comp/env
  then add the remaining context value from the name attribute of the context.xml file in META-INF:
  name = "jdbc/yourfsuid"

  therefore, the full InitialContext lookup() value would be:
  ic.lookup("java:/comp/env/jdbc/yourfsuid")
  */

  private ConnectionPool()
  {
    try
    {
        InitialContext ic = new InitialContext();
        dataSource = (DataSource) ic.lookup("java:/comp/env/jdbc/lgc13");
    }
    catch (NamingException e)
    {
      System.out.println(e);
    }
  }

  public static synchronized ConnectionPool getInstance()
  {
    if (pool == null)
    {
      pool = new ConnectionPool();
    }
    return pool;
  }

  public Connection getConnection()
  {
    try
    {
      return dataSource.getConnection();
    }
    catch (SQLException e)
    {
      System.out.println(e);
      return null;
    }
  }

  public void freeConnection(Connection c)
  {
    try
    {
      c.close();
    } catch (SQLException e)
    {
      System.out.println(e);
    }
  }
}
