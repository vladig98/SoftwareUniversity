function WordsUppercase(str) {
    let words = [...str.toString().split(/[^a-zA-Z0-9]/g)].filter(Boolean);
    words = words.map(el => el.toString().toUpperCase());
    console.log(words.join(", "));
}