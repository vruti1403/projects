 <?php 
include('constants.php'); 
				
		  $c_date =$_GET['c_date'];
                        //Query to Get all Admin
                        $sql = "SELECT * FROM pass_booking where event_date = $c_date ";
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
                                    //Using While loop to get all the data from database.
                                    //And while loop will run as long as we have data in database

                                    //Get individual DAta
									$p_id=$rows['p_id'];
                                    $name=$rows['name'];
                                    $no_of_passes=$rows['no_of_passes'];
									$c_id=$rows['c_id'];
									$e_date=$rows['event_date']

                                    //Display the Values in our Table
                                    ?>
									<tr>
									 <td><?php echo $sn++; ?>. </td>
									 <td><?php echo $name; ?></td>
									 <td><?php echo $e_date; ?></td>
									 <td><?php echo $no_of_passes; ?></td>
										<td><a href="delete-ticket.php?p_id=<?php echo $p_id;?>" class="btn-danger">Cancel Ticket</a>
									 </td>
									</tr>
				 <?php

                                }
                            }
                            else
                            {
                                //We Do not Have Data in Database
                            }
                        }
                    ?>