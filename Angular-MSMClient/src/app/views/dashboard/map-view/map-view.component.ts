import { Component, Input, OnInit } from '@angular/core';
import { NgRedux, select } from 'ng2-redux';
import { Observable } from 'rxjs/Observable';
import { Subscription } from 'rxjs/Subscription';

import { Site, SiteMap } from '../../../models';
import { SiteActions } from '../../../actions';
import { IAppState } from '../../../store';

declare var google: any;

@Component({
    selector: 'map-view',
    templateUrl: './map-view.component.html',
})

export class MapViewComponent implements OnInit {
    myMap: any;
    siteMap: SiteMap[] = [];
    constructor(private ngRedux: NgRedux<IAppState>) {
    }

    ngOnInit() {
        this.initMap();
        this.notifySelectedSite();
    }

    initMap() {
        // Create a map object and specify the DOM element for display.
        var mapProp = {
            center: new google.maps.LatLng(51.508742, -0.120850),
            zoom: 4
        };

        var map = document.getElementById("myMap");
        this.myMap = new google.maps.Map(map, mapProp);
    }

    notifySelectedSite() {
        this.ngRedux.select(state => state.selectedSite)
            .toPromise()
            .then(
                selectedSite => {
                    this.createAllSitesMarker(selectedSite);
                    this.getSiteMarker(selectedSite);
                });
    }

    getSiteMarker(site: Site) {
        if (site == null) {
            return;
        }

        if (site.id === 0) {
            return this.myMap.setZoom(4);
        }

        let foundedMap = this.siteMap.filter(s => s.id === site.id)[0];
        google.maps.event.trigger(foundedMap.marker, 'click');
    }

    createAllSitesMarker(site: Site) {
        if (site == null) {
            return;
        }

        this.createSiteMarker(site);

        if (site.children === null || site.children.length === 0) {
            return;
        }

        site.children.forEach(element => {
            this.createSiteMarker(element);
        });
    }

    createSiteMarker(site: Site) {
        if (site == null) {
            return;
        }

        //Reset the map zoom
        let position = new google.maps.LatLng(site.latitude, site.longitude);
        let marker = new google.maps.Marker({
            position: position,
            title: site.description,
            map: this.myMap,
        });

        this.siteMap.push(new SiteMap({ id: site.id, marker: marker }));

        // Create the info window
        this.makeInfoWindowEvent(this.myMap, site, marker);
    }

    makeInfoWindowEvent(map, site: Site, marker) {
        var infowindow = new google.maps.InfoWindow();
        var content = `<div>
        <p> Site name: `+ site.description + `</p>
        <p> Latitude: ` + site.latitude + `</p>
        <p> Longtitude: ` + site.longitude + `</p>
        </div>`;

        google.maps.event.addListener(marker, 'click', function () {
            infowindow.setContent(content);
            map.setZoom(7);
            map.setCenter(marker.getPosition());
            infowindow.open(map, marker);
        });
    }
}