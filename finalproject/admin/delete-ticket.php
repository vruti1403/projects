<?php
include('constants.php');
 // 1. get the ID of Admin to be deleted
    $p_id = $_GET['p_id'];
    

    //2. Create SQL Query to Delete Admin
    $sql = "DELETE FROM pass_booking WHERE p_id=$p_id";
    $sql1 = "DELETE FROM tbl_payment WHERE p_id = $p_id";

	//3. execute the query
    $res1 = mysqli_query($conn, $sql1);
	$res = mysqli_query($conn, $sql);

    // Check whether the query executed successfully or not
    if($res==true)
    {
        //Query Executed Successully and Admin Deleted
        //echo "Admin Deleted";
        //Create SEssion Variable to Display Message
        $_SESSION['delete'] = "<div class='success'>Passes cancel successfully.</div>";
        //Redirect to Manage Admin Page
        header('location: manage-ticket2.php');
    }
    else
    {
        //Failed to Delete Admin
        //echo "Failed to Delete Admin";

        $_SESSION['delete'] = "<div class='error'>Failed to cancel ticket. Try Again Later.</div>";
        header('location: manage-ticket2.php');
    }

    //3. Redirect to Manage Admin page with message (success/error)

?>