
var raster = new ol.layer.Tile({
    source: new ol.source.OSM()
});

var source = new ol.source.Vector({ wrapX: false });

var vector = new ol.layer.Vector({
    source: source
});

var kapi_layer = new ol.layer.Vector({
    source: new ol.source.Vector()

});
var mahalle_layer = new ol.layer.Vector({
    source: new ol.source.Vector()
});

var map = new ol.Map({
    layers: [raster, vector],
    target: 'map',
    view: new ol.View({
        center: [28.96, 41.03],
        zoom: 4,
        projection: "EPSG:4326"

    })

});
