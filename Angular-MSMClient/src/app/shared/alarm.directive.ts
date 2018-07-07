import { Directive, HostListener, ElementRef } from '@angular/core';

@Directive({
    selector: '[rollingAlarmToggle]'
})
export class RollingAlarmToggleDirective {

    constructor() { }

    @HostListener('click', ['$event'])
    toggleOpen($event: any) {
        $event.preventDefault();
        var alarm = document.getElementById("rolling-alarm");
        alarm.classList.toggle('hidden');
        var maint = document.getElementById("main-content");
        maint.classList.toggle('full-screen');
        maint.classList.toggle('active');
    }
}