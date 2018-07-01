import { Directive, HostListener, ElementRef } from '@angular/core';

@Directive({
    selector: '[activeToggle]'
})
export class ActiveToggleDirective {

    constructor(private el: ElementRef) { }

    @HostListener('click', ['$event'])
    toggleOpen($event: any) {
        $event.preventDefault();
        var hElement: HTMLElement = this.el.nativeElement;
        var x = document.getElementsByName("displayItem");
        var i;
        for (i = 0; i < x.length; i++) {
            x[i].classList.remove('active');
        }

        hElement.classList.toggle('active');
    }
}