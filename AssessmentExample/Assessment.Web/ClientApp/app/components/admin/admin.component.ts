import { Component } from '@angular/core';

@Component({
    selector: 'admin',
    templateUrl: './admin.component.html',
    styleUrls: ['./admin.component.css']
})
export class AdminComponent {
    public currentCount = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
