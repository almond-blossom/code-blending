-- 2017-02-25
-- 입력받은 문자열이 숫자인지 여부 구하기
-- ex) "12345" => true
--     "123a5" => false

asciiZero = string.byte("0")
asciiNine = string.byte("9")

function isNumeric(str)
    for i = 1, #str do
        ascii = str:byte(i)
        if ascii < asciiZero or ascii > asciiNine then
            return false
        end 
    end
    return true
end

res = isNumeric (arg[1])

print("'" .. arg[1] .. "' is " .. (res and "Numeric!" or "not Numeric!"))

