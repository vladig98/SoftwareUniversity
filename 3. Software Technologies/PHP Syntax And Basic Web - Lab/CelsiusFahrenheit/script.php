<form>
    Celsius: <input type="text" name="cel" />
    <input type="submit" value="Convert">
    <?php
        if (isset($_GET['cel'])) {
            $cel = htmlspecialchars($_GET['cel']);
            $fah = $cel * 9/5 + 32;
            echo "<span>$cel &deg;C = $fah &deg;F</span>";
        }
    ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah" />
    <input type="submit" value="Convert">
    <?php
    if (isset($_GET['fah'])) {
        $fah = htmlspecialchars($_GET['fah']);
        $cel = ($fah - 32) * 5/9;
        echo "<span>$fah &deg;F = $cel &deg;C</span>";
    }
    ?>
</form>