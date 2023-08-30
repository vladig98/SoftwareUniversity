<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
	<!--Write your PHP Script here-->
    <?php
        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
            $first = 0;
            $second = 1;
            $count = 1;
            echo $second." ";
            while ($count != $num) {
                $next = $first + $second;
                $first = $second;
                $second = $next;
                echo $next." ";
                $count++;
            }
        }
    ?>
</body>
</html>