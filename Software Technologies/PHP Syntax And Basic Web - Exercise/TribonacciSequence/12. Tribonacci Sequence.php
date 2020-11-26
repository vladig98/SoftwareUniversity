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
        $seq = [];
        for ($i = 0; $i < $num; $i++) {
            if ($i == 0) {
                $seq[] = 1;
            } else if ($i == 1) {
                $seq[] = 1;
            } else if ($i == 2) {
                $seq[] = 2;
            } else {
                $seq[] = $seq[$i - 1] + $seq[$i - 2] + $seq[$i - 3];
            }
        }
        echo implode(" ", $seq);
    }
    ?>
</body>
</html>