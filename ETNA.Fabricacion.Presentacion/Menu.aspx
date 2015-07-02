﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="PresentationLayer.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Style/Menu_jquery.css" rel="stylesheet" />
        <script src="Scripts/jquery-ui-1.8.17.custom/development-bundle/jquery-1.7.1.js"></script>
    <link href="Scripts/jquery-ui-1.8.17.custom/css/ui-lightness/jquery-ui-1.8.17.custom.css" rel="stylesheet" />
    <script src="Scripts/jquery-ui-1.8.17.custom/js/jquery-1.7.1.min.js"></script>
    <script src="Scripts/jquery-ui-1.8.17.custom/js/jquery-ui-1.8.17.custom.min.js"></script>
    <script src="Scripts/jquery-ui-1.8.17.custom/js/jquery.ui.timepicker.js"></script>

    <!-- prefix free to deal with vendor prefixes -->
<script src="http://thecodeplayer.com/uploads/js/prefixfree-1.0.7.js" type="text/javascript" type="text/javascript"></script>

    </head>
<body>
    <form id="form1" runat="server">
   <div id="accordian">
	<ul>
		<li>
			<h3><span class="icon-dashboard"></span>Dashboard</h3>
			<ul>
				<li><a href="#">Reports</a></li>
				<li><a href="#">Search</a></li>
				<li><a href="#">Graphs</a></li>
				<li><a href="#">Settings</a></li>
			</ul>
		</li>
		<!-- we will keep this LI open by default -->
		<li class="active">
			<h3><span class="icon-tasks"></span>Tasks</h3>
			<ul>
				<li><a href="#">Today's tasks</a></li>
				<li><a href="#">Urgent</a></li>
				<li><a href="#">Overdues</a></li>
				<li><a href="#">Recurring</a></li>
				<li><a href="#">Settings</a></li>
			</ul>
		</li>
		<li>
			<h3><span class="icon-calendar"></span>Calendar</h3>
			<ul>
				<li><a href="#">Current Month</a></li>
				<li><a href="#">Current Week</a></li>
				<li><a href="#">Previous Month</a></li>
				<li><a href="#">Previous Week</a></li>
				<li><a href="#">Next Month</a></li>
				<li><a href="#">Next Week</a></li>
				<li><a href="#">Team Calendar</a></li>
				<li><a href="#">Private Calendar</a></li>
				<li><a href="#">Settings</a></li>
			</ul>
		</li>
		<li>
			<h3><span class="icon-heart"></span>Favourites</h3>
			<ul>
				<li><a href="#">Global favs</a></li>
				<li><a href="#">My favs</a></li>
				<li><a href="#">Team favs</a></li>
				<li><a href="#">Settings</a></li>
			</ul>
		</li>
	</ul>
</div>




    </form>
</body>
</html>
