<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profile.aspx.vb" Inherits="Gym_managment_system.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
			body{
  background-color:#2D3047;
}

div{
  background-color:#419D78;
  color:#EFD0CA;
  font-size:20px;
    text-align:left;

}
img{
	background-color:#419D78;
}
	.auto-style2 {
		height: 42px;
	}
	.sign{
		font-family:Respective;
	}
</style>

	
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
      <center> <h1> ABOUT&nbsp;&nbsp;<span style="color:blue"> ME</span><br /></h1> </center> 
			<br />
			<br />
			<img src="images/Razin%20profile1.png" height="280" align="left" /><h2>
&nbsp;&nbsp; I&#39;M Razin Shaikh</h2>
			<p>
				&nbsp; Bsc.Computrer Science from Gujarat Arts &amp; Science College</p>
			<p>
				&nbsp; near Town Hall.&nbsp; I am student. &nbsp;</p>
			<h1 class="sign">Razin Shaikh&nbsp;</h1>
			<p class="sign">&nbsp;</p>
			<p class="sign">&nbsp;</p>
			<div Id="some_div">
	</div>
				</div>
		<!--	Timer java script -->
		<script type="text/javascript">
			var timeLeft = 10;
			var elem = document.getElementById('some_div');
			var timerId = setInterval(countdown, 1000);

			function countdown() {
				if (timeLeft == -1) {
					clearTimeout(timerId);
					doSomething();
				} else {
					elem.innerHTML = '     Redirect to Home page in  ' + timeLeft + '  second. ' ;
					timeLeft--;
				}
			}

			function doSomething() {
				window.location = "Default.aspx"
						//		alert("Hi");

			}


			function checkSecond(sec) {
				if (sec < 10 && sec >= 0) { sec = "0" + sec }; // add zero in front of numbers < 10
				if (sec < 0) { sec = "59" };
				return sec;
			}

		</script>
			</form>	

</body>
</html>
