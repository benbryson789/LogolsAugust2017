import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { Assessment } from './../../entities/assessment';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent {
    public assessments: Assessment[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Assessment/').subscribe(result => {
            this.assessments = result.json() as Assessment[];
        }, error => console.error(error));
    }
}
