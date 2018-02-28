
var xmlhttp = new XMLHttpRequest();
xmlhttp.onreadystatechange = function () {
    if (this.readyState == 4 && this.status == 200) {
        var myArr = JSON.parse(this.responseText);
        document.getElementById("base").innerHTML = myArr[0].ItemDescription.Menuitems[1].Description;
    }
};
xmlhttp.open("GET", "https://cms.smitegame.com/wp-json/smite-api/getItems/1", true);
xmlhttp.send();
