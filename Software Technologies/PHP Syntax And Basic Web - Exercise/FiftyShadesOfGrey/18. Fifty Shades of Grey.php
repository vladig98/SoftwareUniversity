<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<!--Write your PHP Script here-->
<?php
    for ($i = 0; $i < 5; $i++) {
        $color1 = $i * 51;
        $color2 = $i * 51;
        $color3 = $i * 51;
        for ($j = 0; $j < 10; $j++) {
            echo "<div style='background-color: rgb($color1, $color2, $color3)'></div>";
            $color1 = $color1 + 5;
            $color2 = $color2 + 5;
            $color3 = $color3 + 5;
        }
        echo "<br />";
    }
?>
</body>
</html>