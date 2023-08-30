<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        X: <input type="text" name="num1" />
		Y: <input type="text" name="num2" />
        Z: <input type="text" name="num3" />
		<input type="submit" />
    </form>
	<!--Write your PHP Script here-->
    <?php
    if (isset($_GET['num1']) && isset($_GET['num2'])) {
        $num1 = htmlspecialchars($_GET['num1']);
        $num2 = htmlspecialchars($_GET['num2']);
        $num3 = htmlspecialchars($_GET['num3']);
        $count = 0;
        if ($num1 < 0) $count++;
        if ($num2 < 0) $count++;
        if ($num3 < 0) $count++;
        if ($count % 2 == 0) {
            $result = 'Positive';
        } else {
            $result = 'Negative';
        }
        if ($num1 == 0 || $num2 == 0 || $num3 == 0) $result = 'Positive';
        echo $result;
    }
    ?>
</body>
</html>