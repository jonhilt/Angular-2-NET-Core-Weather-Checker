import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'weather',
    template: require('./weather.component.html')
})
export class WeatherComponent {
    public weather: Weather;

    constructor(private http: Http) {
    }

    public getWeather(chosenCity: string) {
        this.http.get('/api/weather/city/' + chosenCity).subscribe(result => {
            this.weather = result.json();
        });
    }
}

interface Weather {
    temp: string;
    summary: string;
    city: string;
}