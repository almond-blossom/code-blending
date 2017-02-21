<?php
    /**
     * 2017-02-12
     * 입력받은 수 n의 제곱근 x가 정수라면 x+1의 제곱 출력
     * 아니라면 'no' 출력
     * ex) 121 => 144
     * ex) 3 => 'no'
     */

    $input1 = 121;
    $input2 = 3;

    function nextSqaure($n) {
        $sqrt = sqrt($n);
        $floor = floor($sqrt);
        $diff = $sqrt - $floor;

        echo "[$n] : ";
        if ($diff == 0)
            echo "($sqrt + 1) ^ 2 : " . pow($sqrt + 1, 2) . "\n";
        else
            echo "no($n)\n";
    }

    nextSqaure($input1);
    nextSqaure($input2);
?>

