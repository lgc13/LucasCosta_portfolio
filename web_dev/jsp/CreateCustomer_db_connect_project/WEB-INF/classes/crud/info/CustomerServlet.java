// save as "<TOMCAT_HOME>\webapps\lis4368\WEB-INF\classes\crud\info\CustomerListServlet.java"
/*
1. Compile:
Windows:
  cd to C:\tomcat\webapps\lis4368\WEB-INF\classes
  javac -cp .;c:\tomcat\lib\servlet-api.jar crud/info/CustomerServlet.java

Mac:
  cd to /Applications/tomcat/webapps/lis4368/WEB-INF/classes
  javac -cp .:/Applications/tomcat/lib/servlet-api.jar crud/info/CustomerServlet.java

2. Run: http://localhost:9999/lis4368/customerList
*/
package crud.info;

import java.io.*;

//comment
import java.util.*;
import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.annotation.*;

import crud.business.Customer;
import crud.data.CustomerDB;

//comment
//servlet CustomerList is mapped to the URL pattern /customerList. When accessing this servlet, it will return a message.
@WebServlet("/customerAdmin")
public class CustomerServlet extends HttpServlet
{
	//perform different request data processing depending on transfer method (here, Post or Get)
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException
	{
    // comment
    HttpSession session = request.getSession();

    //comment
    String url = "/index.jsp"; //initialize url value (used for logic below)

    //comment
    String action = null;
    String cid = null;

    // comment
    // comment

    //comment
    if (request.getParameter("display_customer") != null)
    {
      action = "display_customer";
      //comment
      cid = request.getParameter(action);
    }
    //comment
    else if (request.getParameter("add_customer") != null)
    {
      action = "add_customer";
      cid = null;
    }
    //comment
    else if (request.getParameter("update_customer") != null)
    {
      action = "update_customer";
      cid = request.getParameter(action);
    }
    //comment
    else if (request.getParameter("delete_customer") != null)
    {
      action = "delete_customer";
      cid = request.getParameter(action);
    }
    //comment
    else if (request.getParameter("thanks") != null)
    {
      action = "join";
    }
    else
    {
      url = "/index.jsp";
    }

    // comment
    if (action.equals("join"))
    {
      url = "/customerform.jsp";
    }

    else if (action.equals("display_customer"))
    {
      //comment
      Customer user = CustomerDB.selectCustomer(cid);
      session.setAttribute("user", user);
      url = "/customer.jsp";
    }
    else if (action.equals("add_customer"))
			{
				// get parameters from the request (data conversions not required here)
				//Reality-check: zip should be int, phone long, balance and totalSales BigDecimal data types
        //another comment
        String id = request.getParameter(null);
        String firstName = request.getParameter("fname");
				String lastName = request.getParameter("lname");
				String street = request.getParameter("street");
				String city = request.getParameter("city");
				String state = request.getParameter("state");
				String zip = request.getParameter("zip");
				String phone = request.getParameter("phone");
				String email = request.getParameter("email");
				String balance = request.getParameter("balance");
				String totalSales = request.getParameter("total_sales");
				String notes = request.getParameter("notes");

        //comment
        Customer user = new Customer(id, firstName, lastName, street, city, state, zip, phone, email, balance, totalSales, notes);

        //comment
        String message; //display entry issues encountered to user
				//here: check *only* for data entry
				//empty string: string with zero length.
				//null value: is unknown value--not having a string.

				//Reality-check: in production environment need rigorous data validation:
				//http://java-source.net/open-source/validation
				if (firstName == null || lastName == null || street == null || city == null || state == null || zip == null || phone == null ||   email == null || balance == null || totalSales == null ||

						firstName.isEmpty() || lastName.isEmpty() || street.isEmpty() || city.isEmpty() || state.isEmpty() || zip.isEmpty() || phone.isEmpty() ||  email.isEmpty() || balance.isEmpty() || totalSales.isEmpty()





            )
					{
						message = "All text boxes required except Notes.";
						url = "/customerform.jsp";
					}
        // else if (!firstName.matches("([a-zA-Z\\-]+)") || firstName.length() > 15)
        // {
        //   message = "First name can only contain letters and hyphens.";
        //   url = "/customerform.jsp";
        // }
        // else if (!lastName.matches("([a-zA-Z\\-]+)") || lastName.length() > 30)
        // {
        //   message = "Last name no more than 30 characters";
        //   url = "/customerform.jsp";
        // }
        // else if (!street.matches("([a-zA-Z0-9,\\s\\.]+)") || street.length() > 30)
        // {
        //   message = "Street can only contain letters, numbers, commas, or periods";
        //   url = "/customerform.jsp";
        // }
        // else if (!city.matches("([a-zA-Z0-9\\-\\s]+") || city.length() > 30)
        // {
        //   message = "City can only contain letters and numbers";
        //   url = "/customerform.jsp";
        // }
        // else if (!state.matches("([a-zA-Z]+)") || state.length() > 2)
        // {
        //   message = "State can only letters";
        //   url = "/customerform.jsp";
        // }
        // else if (!zip.matches("([0-9]+)") || zip.length() > 9)
        // {
        //   message = "Zip must contain only numbers";
        //   url = "/customerform.jsp";
        // }
        // else if (!phone.matches("([0-9]+)") || phone.length() > 10)
        // {
        //   message = "Phone must have 10 numeric characters";
        //   url = "/customerform.jsp";
        // }
        // else if (!email.matches("([a-z0-9_\\.-]+)@([\\da-z\\.-]+)\\.([a-z\\.]{2,6})") || email.length() > 100)
        // {
        //   message = "Must include valid email";
        //   url = "/customerform.jsp";
        // }
        // else if (!balance.matches("([0-9\\.]+)") || balance.length() > 11)
        // {
        //   message = "Must include a balance";
        //   url = "/customerform.jsp";
        // }
        // else if (!totalSales.matches("([0-9\\.]+)") || totalSales.length() > 11)
        // {
        //   message = "Must include total sales";
        //   url = "/customerform.jsp";
        // }
				else
					{
						message = "";
						url = "/thanks.jsp";
            CustomerDB.insert(user);
					}
				request.setAttribute("user", user);
				request.setAttribute("message", message);
			}
      else if (action.equals("update_customer"))
      {
        //comment
        String firstName = request.getParameter("fname");
				String lastName = request.getParameter("lname");
				String street = request.getParameter("street");
				String city = request.getParameter("city");
				String state = request.getParameter("state");
				String zip = request.getParameter("zip");
				String phone = request.getParameter("phone");
				String email = request.getParameter("email");
				String balance = request.getParameter("balance");
				String totalSales = request.getParameter("total_sales");
				String notes = request.getParameter("notes");

        //comment
        Customer user = (Customer) session.getAttribute("user");
        user.setId(cid);
        user.setFname(firstName);
        user.setLname(lastName);
        user.setStreet(street);
        user.setCity(city);
        user.setState(state);
        user.setZip(zip);
        user.setPhone(phone);
        user.setEmail(email);
        user.setBalance(balance);
        user.setTotalSales(totalSales);
        user.setNotes(notes);

          url = "/modify.jsp";
          //update
        CustomerDB.update(user);

        //comment
        ArrayList<Customer> users = CustomerDB.selectCustomers();
        request.setAttribute("users", users);
      }
      else if(action.equals("delete_customer"))
      {
        //comment
        Customer user = CustomerDB.selectCustomer(cid);

        url = "/modify.jsp";
        //comment
        CustomerDB.delete(user);

        //comment
        ArrayList<Customer> users = CustomerDB.selectCustomers();
        request.setAttribute("users", users);
      }

      //comment

		getServletContext()
			.getRequestDispatcher(url)
			.forward(request, response);
	}

	@Override
	protected void doGet(HttpServletRequest request, HttpServletResponse response)
		throws ServletException, IOException
	{
    String url = "/modify.jsp";

    //comment
    ArrayList<Customer> users = CustomerDB.selectCustomers();
    request.setAttribute("users", users);

    //comment
    getServletContext()
			.getRequestDispatcher(url)
			.forward(request, response);

    //comment
    //comment
    //comment
	}
}
