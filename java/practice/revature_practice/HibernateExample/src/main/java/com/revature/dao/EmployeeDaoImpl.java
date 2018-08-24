package com.revature.dao;

import java.util.List;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.hibernate.Transaction;

import com.revature.bean.Employee;
import com.revature.util.HibernateUtil;

public class EmployeeDaoImpl implements EmployeeDao {

	@Override
	public int insertEmployee(Employee emp) {

		Session session = HibernateUtil.getSession(); // gets session
		Transaction tx = null;
		Integer empId = null;

		try {
			tx = session.beginTransaction();
			empId = (Integer) session.save(emp);
			tx.commit();

		} catch (HibernateException e) {
			if (tx != null) {
				tx.rollback();
			}
			e.printStackTrace();
		} finally {
			session.close();
		}

		return empId;
	}

	@Override
	public Employee getEmployeeById(Integer id) {

		Session session = HibernateUtil.getSession(); // gets session
		Transaction tx = null;
		Employee emp = null;

		try {
			tx = session.beginTransaction(); // begins transaction
			emp = (Employee)session.get(Employee.class, id);
			

		} catch (HibernateException e) {
			if (tx != null) {
				tx.rollback();
			}
			e.printStackTrace();
		} finally {
			session.close();
		}

		return emp;
	}

	@Override
	public List<Employee> getAllEmployees() {

		List<Employee> emps = null;
		Session session = HibernateUtil.getSession(); // gets session
		Transaction tx = null;

		try {
			tx = session.beginTransaction();
			emps = session.createQuery("FROM Employee").list(); // HQL SELECTS from classname, not table name

		} catch (HibernateException e) {
			if (tx != null) {
				tx.rollback();
			}
			e.printStackTrace();
		} finally {
			session.close();
		}

		return emps;
	}

	@Override
	public void setEmployee(Employee emp) {

	}

	@Override
	public void deleteEmployee(Integer id) {

	}

}
