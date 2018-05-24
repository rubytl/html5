import { Component, OnInit, OnDestroy, Input, Output, EventEmitter } from '@angular/core';

export class MsmTemplateComponent implements OnInit, OnDestroy {
    @Output() valueChanged = new EventEmitter<any>();
    @Input() value: any;

    ngOnInit() {
        this.onComponentInit();
    }

    ngOnDestroy() {
        this.valueChanged.unsubscribe();
    }

    protected onValueChanged() {
        this.valueChanged.next(this.value);
    }

    protected onComponentInit() {
    }
}
