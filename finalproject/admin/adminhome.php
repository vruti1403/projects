<?php include('partials/menu.php'); ?>
<html>
<body>
<html>
    <head>
        <title>ADMIN - Home Page</title>
    </head>
    <body>
        
        <!-- Main Content Section Starts -->
        <div class="content">
            <div class="cards">
                <div class="card">
                    <div class="box">
                        <?php $sql="select * from tbl_admin";
                         $res = mysqli_query($conn, $sql);
                         $count = mysqli_num_rows($res);
                        
                        ?>
                        <h1><?php echo $count?></h1>
                        <h3>ADMIN</h3>
                    </div>
                    <div class="icon-case">
                        <img src="students.png" alt="">
                    </div>
                </div>
                <div class="card">
                    <div class="box">
                    <?php $sql="SELECT * FROM `tbl_concert` WHERE `c_date`>= curdate() + 1";
                         $res = mysqli_query($conn, $sql);
                         $count = mysqli_num_rows($res);
                        ?>
                        <h1><?php echo $count?></h1>
                        <h3> EVENTS</h3>
                        <img src="schools.png" alt="">
                    </div>
                    <div class="icon-case">
                        
                    </div>
                </div>
                <div class="card">
                    <div class="box">
                        <?php $sql1 = "SELECT SUM(no_of_passes) as total from pass_booking";
                        $res1 = mysqli_query($conn, $sql1);
                        $row1 = mysqli_fetch_assoc($res1);
                        $total_revenue = $row1['total'];
                        ?>
                        <h1><?PHP echo $total_revenue; ?></h1>
                        <h3>PASS SOLD</h3>
                    </div>
                    <div class="icon-case">
                    <img src="teachers.png" alt="">
                       
                    </div>
                </div>
                <div class="card">
                    <div class="box">
                    <?php $sql1 = "SELECT SUM(total_amount) as total from tbl_payment";
                        $res1 = mysqli_query($conn, $sql1);
                        $row1 = mysqli_fetch_assoc($res1);
                        $total_revenue = $row1['total'];
                        ?>
                        <h1><?PHP echo $total_revenue; ?></h1>
                        <h3>INCOME</h3>
                    </div>
                    <div class="icon-case">
                        <img src="income.png" alt="">
                    </div>
                </div>
            </div>
            <div class="content-2">
<div class="recent-payments">
   <div class="title">
       <h2>Details</h2> 
                          
<form method="POST" action="">                
				<tr><td>Event date :</td>
				
				<td>
                        <select name="event_date">
						<?php 
                                //Create PHP Code to display categories from Database
                                //1. CReate SQL to get all active categories from database
                                $sql = "SELECT * FROM tbl_concert ";
                                
                                //Executing qUery
                                $res = mysqli_query($conn, $sql);

                                //Count Rows to check whether we have categories or not
                                $count = mysqli_num_rows($res);

                                //IF count is greater than zero, we have categories else we donot have categories
                                if($count>0)
                                {
                                    //WE have categories
                                    while($row=mysqli_fetch_assoc($res))
                                    {
                                        //get the details of categories
                                       // $c_id = $row['c_id'];
                                        //$c_date = $row['c_date'];7
                                        $c_artist= $row['c_artist'];

                                        ?>

                                        <option value="<?php echo $c_artist; ?>"><?php echo $c_artist; ?></option>

                                        <?php
                                    }
                                }
                                else
                                {
                                    //WE do not have category
                                    ?>
                                    <option value="0">No Concert Found</option>
                                    <?php
                                }
                            

                                //2. Display on Drpopdown
                            ?>
						  </select>
                    </td>
				<td colspan="2">
                        <input type="submit" class="btn btn-primary"name="submit" value="Search Concert" class="btn-secondary">
                    </td></tr></FORM>

                      
</div>


   <table>
       <tr>
<th>Sr.no</th>
<th>Date</th>
<th>Artist</th>
<th>No of passes</th>
<th>Total Income</th>
       </tr>
   
</div>

<?php 
 if(isset($_POST['submit']))
 {
    $c_artist = $_POST['event_date'];
    $sql = "SELECT * FROM tbl_concert where c_artist = $c_artist";
    //Execute the Query
    $res = mysqli_query($conn, $sql);

    //CHeck whether the Query is Executed of Not
    if($res==TRUE)
    {
        // Count Rows to CHeck whether we have data in database or not
        $count = mysqli_num_rows($res); // Function to get all the rows in database

        $sn=1; //Create a Variable and Assign the value

        //CHeck the num of rows
        if($count>0)
        {
            //WE HAve data in database
            while($rows=mysqli_fetch_assoc($res))
            {
                $c_id=$rows['c_id'];
                $c_date=$rows['c_date'];
                $c_artist=$rows['c_artist'];
                $sql1 = "SELECT sum(no_of_passes) as tpass , sum(total_amount) as tincome FROM tbl_payment where c_id= $c_id ";
                $res1 = mysqli_query($conn, $sql1);
                if($res1==TRUE)
                {
                 $row1 = mysqli_fetch_assoc($res1);
                 $total_pass = $row1['tpass'];
                     $total_revenue = $row1['tincome'];
                 }
                
                ?>
                <tr>
                <td><?php echo $sn++;?></td>
                 <td><?php echo $c_date;?></td>
                 <td><?php echo $c_artist;?></td>
                 <td><?php echo $total_pass;?></td>
                 <td><?php echo $total_revenue;?></td>
                </tr>
<?php

            }
        }
        else
        {
           echo "no concert until now";
        }
    }  
 }
 if(!isset($_POST['submit']))
 {
       //Query to Get all Admin
       $sql = "SELECT * FROM tbl_concert order by c_date";
       //Execute the Query
       $res = mysqli_query($conn, $sql);

       //CHeck whether the Query is Executed of Not
       if($res==TRUE)
       {
           // Count Rows to CHeck whether we have data in database or not
           $count = mysqli_num_rows($res); // Function to get all the rows in database

           $sn=1; //Create a Variable and Assign the value

           //CHeck the num of rows
           if($count>0)
           {
               //WE HAve data in database
               while($rows=mysqli_fetch_assoc($res))
               {
                   $c_id=$rows['c_id'];
                   $c_date=$rows['c_date'];
                   $c_artist=$rows['c_artist'];
                   $sql1 = "SELECT sum(no_of_passes) as tpass , sum(total_amount) as tincome FROM tbl_payment where c_id= $c_id ";
                   $res1 = mysqli_query($conn, $sql1);
                   if($res1==TRUE)
                   {
                    $row1 = mysqli_fetch_assoc($res1);
                    $total_pass = $row1['tpass'];
                        $total_revenue = $row1['tincome'];
                    }
                   
                   ?>
                   <tr>
                   <td><?php echo $sn++;?></td>
                    <td><?php echo $c_date;?></td>
                    <td><?php echo $c_artist;?></td>
                    <td><?php echo $total_pass;?></td>
                    <td><?php echo $total_revenue;?></td>
                   </tr>
<?php

               }
           }
           else
           {
              echo "no concert until now";
           }
       }
    }
   ?>
</div>
</table>
</div>

        </div>
</div>

				 </body>
				 </html>
				 