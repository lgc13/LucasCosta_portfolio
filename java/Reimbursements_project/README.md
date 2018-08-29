# Reimbursements App project

<!-- Project BIO -->
This application is made to be used in a professional environment, where employees and managers can request reimbursements for job related expenses. Employees and managers can login, see and change their personal info(such as name, username, and password), and also submit reimbursement requests. Managers have additional features that are only available for them, such as viewing all employees, changing any employee's information, accepting or denying employee's reimbursement requests.

This application displays some of my skills with:

- Full MVC (Model-View-Controller)
- User authentication (Employee vs Manager views)
- Use of GET/POST Request methods
- Oracle Database query
- JSP/JSTL use for dynamic web pages

<!-- Screenshots -->
<img src="img/invalid_login.PNG" width= 80% length= 80%>
<img src="img/login_employee.PNG" width= 80% length= 80%>
<img src="img/login_manager.PNG" width= 80% length= 80%>
<img src="img/info_edit_employee.PNG" width= 80% length= 80%>
<img src="img/employee_create_manager.PNG" width= 80% length= 80%>
<img src="img/reimbursements_manager.PNG" width= 80% length= 80%>
<img src="img/reimbursements_request_employee.PNG" width= 80% length= 80%>
<img src="img/reimbursements_updated_manager.PNG" width= 80% length= 80%>
<img src="img/reimbursements_viewUpdated_employee.PNG" width= 80% length= 80%>


<!-- Code explanation -->
This is a very straight forward application which needs some basic types of methods, such as one to create an employee, one to select the employee by username (can be used when logging in), selecting all employees from the database onto an Array List, and also a few others to edit the employee. By having an interface with these methods, it is very easy to keep track of how I can query through my Oracle database.

<!-- Code snippet -->
You can see that in this code snippet:

```java

public interface UserDAO {

	public void createEmployee(EmployeeObject employee);
	public EmployeeObject selectEmployeeByUsername(String username);
	public EmployeeObject selectEmployeeById(int id);
	public ArrayList<EmployeeObject> selectEmployee();
	public ArrayList<EmployeeObject> selectAllEmployees();
	public EmployeeObject updateEmployee(EmployeeObject employee);
	public void deleteEmployeeById(int id);

}


```

<!-- Code explanation -->
When a person is trying to login, I can use the input username to double check on my database along with its password. I can also do some simple server side validation where if the person object is blank to begin with, I can just deny them access. In addition, by getting the entire person's object, I'll have access to their "role", whether that's an "employee" or "manager", allowing me to create a different page view depending on that attribute.

<!-- Code snippet -->
You can see that in this code snippet:


```java

person = userDao.selectEmployeeByUsername(username);

if (person!=null)
{
  if (username.equals(person.getUser_username()) && pass.equals(person.getUser_password()))
  {
    return person;
  }
  else {
    System.out.println("Validate Login - Received null emp");
    return null;
  }
}
else
{
  return null;
}

```


<!-- Adding a blank line -->
<br>

<!-- Back to Projects folder -->
<a href="https://github.com/lgc13/LucasCosta_portfolio/tree/master/java/" class="previous">&laquo; Back to Java projects</a>
