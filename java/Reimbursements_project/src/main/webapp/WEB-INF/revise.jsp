<!-- JSTL tags -->
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/functions" prefix="fn"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/sql" prefix="sql"%>
<%-- importing pojo and dao packages --%>
<%@ page import="com.revature.pojo.*, com.revature.dao.*" %>

<!DOCTYPE html>
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

<script type="text/javascript" src="${pageContext.request.contextPath}/JS/default.js"></script>
<!-- Select character encoding support -->
<link rel="stylesheet" type="text/css" href="${pageContext.request.contextPath}/CSS/default.css">


<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Project 1</title><!-- tab title  -->

</head>

	<body>
	
	<%@ include file="nav_bar.jsp" %>  <%-- Bringing in nav bar  --%>
	
	<c:if test="${sessionScope.role_id!=1 }">  <!-- User can only access this page with manager credentials -->
			<jsp:forward page="/WEB-INF/index.jsp"/>
		</c:if>
	
	<div class="well" style='background:white;'>
		<div class="starter-template">
			<div class="row">
				<div class="col-xs-12">
				
				<h2 align="center">Here you can view the request information. Click accept on decline</h2>
				<br>
		<%--action will be read by web container, and go to method doPost in the servlet chosen --%>
		
		<div class="col-xs-8 col-xs-offset-2">
			<form method="post" action="updated" class="form-horizontal">
              <div class="form-horizontal">              
              	<label class="col-xs-5 control-label">RID:</label>
                 	 <p class="form-control-static"><c:out value="${reb.rebsId}" /></p>  
                 	 <input type="hidden" name="reb_id" value="${reb.rebsId}">
                 	 
               
                  <label class="col-xs-5 control-label">Requester:</label>
                 	 <p class="form-control-static"><c:out value="${emp.user_first_name}" /></p>               
                 
                  <label class="col-xs-5 control-label">Reimbursement Type:</label>
                  	<p class="form-control-static">
						<c:choose>	
							<c:when test="${reb.rebsStatus==1}">Business Expense</c:when>
							<c:when test="${reb.rebsStatus==2}">Travel</c:when>
							<c:when test="${reb.rebsStatus==3}">Medical</c:when>
						</c:choose>
					</p>               
                
                  <label class="col-xs-5 control-label">Amount</label>
                  	<p class="form-control-static">
                  		$<fmt:formatNumber type="number" maxFractionDigits="2" value="${reb.rebsAmount}" />
                  		<%-- <c:out value="${reb.rebsAmount}" /> --%>
                  	</p> 
                  	
                  <label class="col-xs-5 control-label">Description</label>
                  	<p class="form-control-static">
                  		<c:out value="${reb.rebsDescription}" />
                  	</p>
                  	
                  <label class="col-xs-5 control-label">Time Submitted</label>
                  	<p class="form-control-static">
                  		<c:out value="${reb.timeSubmitted}" />
                  	</p>
                  	
                  <label class="col-xs-5 control-label">Current Status</label>
                  	<p class="form-control-static">
                  		<c:choose>
                  			<c:when test="${reb.rebsStatus==1}">Pending</c:when>
                  			<c:when test="${reb.rebsStatus==2}">Approved</c:when>
                  			<c:when test="${reb.rebsStatus==3}">Declined</c:when>
                  		</c:choose>
                   	</p> 
                  	
                  <input type="hidden" name="resolver_id" value="${user_id}">
                                 
                  <br>
                  
				<!-- Submit button to create user -->
				<div class="col-xs-5 control-label">
					<input type="submit" name="action" value="DECLINE">
				</div>
				
				<div class="col-xs-3  control-label">
					<input type="submit" name="action" value="APPROVE">
				</div>                           
             
             
              </div>
           	</form>
         </div>
		
				</div>
			</div>
		</div>
	</div>
				
		

	
</body>
</html>