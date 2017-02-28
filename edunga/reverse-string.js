var toValue = char => {
    var ascii = char.charCodeAt(0);
    if (ascii > 'a'.charCodeAt(0) && ascii < 'z'.charCodeAt(0)) return ascii + 10000;
    else if (ascii > 'A'.charCodeAt(0) && ascii < 'Z'.charCodeAt(0)) return ascii + 5000;
    return ascii;
};

var max = (c1, c2) => toValue(c1) > toValue(c2) ? c1 : c2;

var reverseString = str => {
    var split = str.match(/./g);
    split.forEach((i, ii) =>
        split.forEach((j, jj) => {
            if (toValue(i) < toValue(j))
                split[jj] = [split[ii], split[ii] = split[jj]][0];
        })
    );
    return split.join('');
};

if (process.argv.length < 2) {
    console.log(`Usage: ${process.argv[0]} ${process.argv[1]} STRING`);
    return;
}

var arg = process.argv[2];
var reversed = reverseString(arg);
console.log(`${arg} => ${reversed}`);

