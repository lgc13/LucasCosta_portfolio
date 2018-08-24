<!-- JSTL tags -->
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/functions" prefix="fn"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/sql" prefix="sql"%>
<%-- importing pojo and dao packages --%>
<%@ page import="com.revature.pojo.*, com.revature.dao.*" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<!-- Latest compiled and minified CSS -->
<link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

<!-- jQuery library -->
<script
	src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<!-- Latest compiled JavaScript -->
<script
	src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

<!-- This will ensure that mobile will work with site by allowing proper formatting when zooming in -->
<meta name="viewport" content="width=device-width, initial-scale=1">

<!-- Select character encoding support -->
<link rel="stylesheet" type="text/css" href="${pageContext.request.contextPath}/CSS/default.css">


<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<script type="text/javascript" src="${pageContext.request.contextPath}/JS/default.js"></script>
<title>Project 1</title><!-- tab title  -->

</head>

	<body>
	
		<%@ include file="nav_bar.jsp" %>  <%-- Bringing in nav bar  --%>
		
		<%-- <c:if test="${sessionScope.role_id!=1 }"> User can only access this page with manager credentials
			<jsp:forward page="/WEB-INF/index.jsp"/>
		</c:if> --%>
		
		<div class="well">
			<div class="starter-template">
				<div class="row">
					<div class="col-xs-12 ">
			
			<%-- href to "new" which will take it to employees/new =  createemployee.jsp --%>
			<h4><a href="new"><input class="pull-right" type="submit" 
			 value="Create a request"></a></h4>
			
			
			<h2>All reimbursements</h2>
			
			<div class="table-responsive" align="center" >
				<table class="table table-striped">
					<thead>
						<tr>
							<th>RID</th>
							<th>Employee</th>
							<th>Amount</th>
							<th>Type</th>
							<th>Description</th>
							<th>Submitted on</th>
							<th>Attachments</th>
							<th>Status</th>
							<th>Resolver</th>
							<th>Resolved on</th>
						</tr>
					</thead>

					<tbody>
					
					<c:forEach var="r" items="${reimbursements}"> <%-- Getting "users" from front controller --%>
						<tr>
							
							<td><c:out value="${r.rebsId}" /></td>
							
							<td><c:out value="${userDao.selectEmployeeById(r.userId).getUser_first_name()}" /></td>
							<%-- <td><c:out value="${users.get(r.userId - 1).getUser_first_name()}" /></td> --%>
							
							<td>$<fmt:formatNumber type="number" maxFractionDigits="2" value="${r.rebsAmount}" /></td>			
							<%-- <td>$<c:out value="${r.rebsAmount}" />0</td> --%>
							
							<c:choose>
									<c:when test="${r.rebsType==1}" >
										<td>Business</td>
									</c:when>
									<c:when test="${r.rebsType==2}" >
										<td>Travel</td>
									</c:when>
									<c:when test="${r.rebsType==3}" >
										<td>Medical</td>
									</c:when>								
							</c:choose>
							
							<td><c:out value="${r.rebsDescription}" /></td>
							<td><c:out value="${r.timeSubmitted}" /></td>
							<td><c:out value="${r.rebsAttachments}" /></td>
														
							<c:choose>
									<c:when test="${r.rebsStatus==1}" >
										<td id="icon-yellow">Pending</td>
									</c:when>
									<c:when test="${r.rebsStatus==2}" >
										<td id="icon-green">Approved</td>
									</c:when>
									<c:when test="${r.rebsStatus==3}" >
										<td id="icon-red">Declined</td>
									</c:when>								
							</c:choose>
							
							<td>
							<c:choose>
								<c:when test="${r.managerId==0}"> --- </c:when>
								<c:otherwise>
									<c:out value="${users.get(r.managerId - 1).getUser_first_name()}" />
								</c:otherwise>
							</c:choose>
							</td>
							
							<td>
							<c:choose>
								<c:when test="${r.timeResolved!=null}">
									<c:out value="${r.timeResolved}" />
								</c:when>
								<c:otherwise>
									<p> --- </p>
								</c:otherwise>
							</c:choose>
							</td>
							
							<td>
							<c:if test="${role_id==1}">
								<c:choose>
									<c:when test="${r.rebsStatus==1}">
									<form class="form-horizontal" action="revise">
										<input type="hidden" name="rebs_id" value="${r.rebsId}" />
										<input type="submit" value="View" />
									</form>
									</c:when>
								</c:choose>
							</c:if>
							</td>

						</tr>	
					</c:forEach> 
					</tbody>

				</table>

			</div><!-- end table-responsive -->
					</div>
				</div>
			</div>
		</div>
		
		<script src="${pageContext.request.contextPath}/JS/default.js"></script>
	</body>
</html>