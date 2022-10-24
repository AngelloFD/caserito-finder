function addMarker(coords) {
    const marker = new google.maps.Marker({
        position: coords,
        map: map,
    });
}

function initMap() {
    const myLatLng = { lat: -12.0725, lng: -76.9517 };
    const map = new google.maps.Map(document.getElementById("map"), {
        zoom: 15,
        center: myLatLng,
    });
}