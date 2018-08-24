package com.revature.main;

import java.util.List;

import com.revature.bean.Employee;
import com.revature.dao.EmployeeDao;
import com.revature.dao.EmployeeDaoImpl;

public class Driver {

	public static void main(String[] args) {
		
		EmployeeDao dao = new EmployeeDaoImpl();
		Employee e1 = new Employee("Bobbert", "Bobson", "bob@bob.com", 2500);
		Employee e2 = new Employee("Adam", "Adamska", "adam@adam.com", 2533);
		Employee e3 = new Employee("Ryan", "Lessley", "lessley@something.com", 2330);
		
		System.out.println("Inserted an employee with ID: " 
					+ dao.insertEmployee(e1));
		System.out.println("Inserted an employee with ID: " 
				+ dao.insertEmployee(e2));
		System.out.println("Inserted an employee with ID: " 
				+ dao.insertEmployee(e3));
		
		List<Employee> emps = dao.getAllEmployees();
		
		for (Employee e: emps){
			System.out.println(e);
		}
		
		System.out.println(dao.getEmployeeById(2));
	}

}
