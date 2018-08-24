<%-- Use core library --%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<meta name="description" content="My online portfolio that illustrates skills acquired while working through various project requirements.">
	<meta name="author" content="Lucas Costa">
	<link rel="icon" href="favicon.ico">

	<title>Lis 4368 - JSP Forms</title>

	<%@ include file="/css/include_css.jsp" %>

</head>
<body>

<!-- display application path -->
<% //= request.getContextPath()%>

<!-- can also find path like this...<a href="${pageContext.request.contextPath}${'/a5/index.jsp'}">A5</a> -->

	<%@ include file="/global/nav_global.jsp" %>

	<div class="container">
		<div class="starter-template">
			<div class="row">
				<div class="col-xs-12">


					<div class="page-header">
						<%@ include file="/project2/global/header.jsp" %>
					</div>

					<h2><Update Customer</h2>

					<!-- comment -->
					<p><i>WHERE'S THE PIZZA, JOWETT?</i></p>

					<form id="edit_customer_form" method="post" class="form-horizontal" action="customerAdmin">

						<%
						//use for testing input
						//another comment
						%>

						<input type="hidden" name="update_customer" value="${user.id}" />

						<div class="form-group">
							<label class="col-sm-4 control-label">FName:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="15" name="fname" value="${user.fname}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">LName:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="30" name="lname" value="${user.lname}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">Street:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="30" name="street" value="${user.street}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">City:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="30" name="city" value="${user.city}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">State:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="2" name="state" value="${user.state}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">Zip:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="9" name="zip" value="${user.zip}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">Phone:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="10" name="phone" value="${user.phone}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">Email:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="100" name="email" value="${user.email}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">Balance:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="7" name="balance" value="${user.balance}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">Total Sales:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="7" name="total_sales" value="${user.totalSales}" />
							</div>
						</div>

						<div class="form-group">
							<label class="col-sm-4 control-label">Notes:</label>
							<div class="col-sm-4">
								<input type="text" class="form-control" maxlength="255" name="notes" value="${user.notes}" />
							</div>
						</div>

						<div class="form-group">
							<div class="col-sm-6 col-sm-offset-3">
								<button type="submit" class="btn btn-primary" name="signup" value="Update">Update</button>
							</div>
						</div>
					</form>
				</div>
			</div>

	<%@ include file="/global/footer.jsp" %>

</div>
</div>

<%--@ include file="/js/include_js.jsp" --%>
