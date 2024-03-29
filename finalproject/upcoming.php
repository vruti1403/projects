<?php 
include('constants.php'); 
?>
<html>
<style>
body
{
	background-color: F9EBC8;
}
h1{
	font-family: Bodoni MT; 
	font-size: 52;
	text-align: center;
	color: 2F8F9D;
	position: relative;
    bottom: 130;
}
.box span{
    font-size: 20px;
}
.box{
	margin-top: 30px;
    margin-left: 0.5rem;
    font-size: 1.2rem;
    padding: 4.5rem;
    align-items: center;
    background: #fff;
    border-radius: .5rem;
    border: .1rem solid rgba(0,0,0,.2);
    box-shadow: var(--box-shadow);
    position: relative;
    overflow: hidden;
    text-align: center;
	height: 460;
}

.box img{
    height: auto;
    width: 100%;
    border-radius: 5px;
}

.content{
font-family: 'Courier New', monospace;
color: 2F8F9D;
background: white;
position: relative;
top: 26;
left: 0;
width:100%
padding: 20px;
transition: all 0.5s;

}
.btn
{
	position: relative;
	top: -350;
	background-color: DC3535;
  border: none;
  color: white;
  padding: 15px 32px;
  text-align: center;
  text-decoration: none;
  display: inline-block;
  font-size: 16px;
  margin: 4px 2px;
  cursor: pointer;
  width: 200px;
}
.box:hover .content{
top: -300px;	
}
 .box-mania{
    margin-top: 10px;
    align-items: center;
    
    display: grid;
    grid-template-columns: repeat(auto-fit,minmax(27rem,1fr));
    gap:5.5rem;

}
.container {
  text-align: center;
  position: relative;
  bottom: 0;
  color: #f1f1f1;
  width: 100%;
  padding: 20px;
  font-size: 250%;
  font-family: monospace;
}
.logo{
	position: relative;
    right: 60;
	top: -50;
	margin: 0 100 0 100;
	}
a:active
{
color: black;
}
.bar{
	display: inline;
position: relative;
top: -150;
margin: 0 80 0 0;
color: white;
text-decoration: none;
font-weight: 1000;
bottom: 0;
}
.bar:hover{
color: 2F8F9D;
}
.regbtn{
display: inline;
position: relative;
top: -150;
margin: 0 10 0 0;
text-decoration: none;
font-weight: 1000;
bottom: 0;
width: 200px;
background-color: 2F8F9D;
padding: 10px;
color: white;
border: none;
}
</style>
<body>
<div class="container">
<img  class="logo" src="images1.png" alt="Sundown Fest">
<a href="video.php"class="bar">HOME</a>
<a href="booking_stall2.php" class="bar">SELL</a>
<a href="upcoming.php" class="bar">EVENTS</a>
<a href="faq.php" class="bar">FAQ</a>
<a href="generate-ticket.php" class="bar">TICKET</a>
<a href="logout.php"><button type="submit" class="regbtn">LOGOUT</button></a>
</div>
<H1>--Upcoming Events--<H1>
<div class="box-mania">
 <?php 
            if(!isset($_POST['filter'])){
            //Getting Foods from Database that are active and featured
            //SQL Query
            $sql2 = "SELECT * FROM `tbl_concert` WHERE `c_date`>= curdate() + 1";

            //Execute the Query
            $res2 = mysqli_query($conn, $sql2);

            //Count Rows
            $count2 = mysqli_num_rows($res2);

            //CHeck whether food available or not
            if($count2>0)
            {
                //Food Available
                while($row=mysqli_fetch_assoc($res2))
                {
                    //Get all the values
                    $c_id = $row['c_id'];
                $c_date = $row['c_date'];
                $c_venue = $row['c_venue'];
				$venue_capacity = $row['venue_capacity'];
                $c_artist = $row['c_artist'];
                $sql1 = "SELECT sum(no_of_passes) as tpass FROM tbl_payment where c_id= $c_id ";
                $res1 = mysqli_query($conn, $sql1);
                if($res1==TRUE)
                {
                 $row1 = mysqli_fetch_assoc($res1);
                 $total_pass = $row1['tpass'];
                }
                    ?>
<div class="box">
							<img src="images.png" alt="Chicke Hawain Pizza">
							<div class="content">
							
							<h3> THE SUNDOWN FEST<h3>
							<span> SURAT <span><br>
							<p><?php echo $c_date ;?><p>
							<p><?php echo $c_venue ;?><p>
                            <p><?php echo $c_artist ;?> : 500Rs <p>
                            <p> <p>
                            
							<p>The sundown fest is here ! <br> The perfect concoction of shopping ,food , music and people.
							promising to be an unforgottable experience for shopping<br> and music lovers alike<br>
							With 80+ enthralling brands to discover from 15+ food brands ans an outstanding line up of musicians for live music 
							<br>
							 
							<!--<a href="#" class="btn">Add to cart</a>-->
							 </div>
							 <div>
							 <button <?php if ($total_pass == $venue_capacity){ ?> disabled <?php   } ?> >
                             <a href="ticket.php?c_id=<?php echo $c_id;?>&c_date=<?php echo $c_date;?>" class="btn">BUY TICKETS</a></button></div>
						</div>
						<?php
			}
			}
			
			else
            {
                //Food Not Available 
                echo "<div class='error'>Event not available.</div>";
            }
        }
            ?>


           
            </div>
						
						</body>
						<html>