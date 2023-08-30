<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<!--Write your PHP Script here-->
<?php
    for ($i = 0; $i < 5; $i++) {
        for ($j = 0; $j < 5; $j++) {
            if ($i == 0 || $i == 4 || $j == 0) {
                echo "<button style='background-color: blue'>1</button>";
            } else {
                echo "<button>0</button>";
            }
        }
        echo "<br />";
    }
    for ($i = 0; $i < 4; $i++) {
        for ($j = 0; $j < 5; $j++) {
            if ($i == 3 || $j == 4) {
                echo "<button style='background-color: blue'>1</button>";
            } else {
                echo "<button>0</button>";
            }
        }
        echo "<br />";
    }
?>
</body>
</html>