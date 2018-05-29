import { Component, OnChanges, OnDestroy, Input, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

export class MsmTemplateComponent implements OnDestroy, OnChanges {
    @Output() valueChanged = new EventEmitter<any>();
    @Input() value: any;
    templateForm: FormGroup;
    constructor(private fb: FormBuilder) {
        this.templateForm = this.fb.group({ value: '' });
    }

    ngOnDestroy() {
        this.valueChanged.unsubscribe();
    }

    ngOnChanges() {
        this.rebuildForm();
    }

    rebuildForm() {
        this.templateForm.reset({
            value: this.value
        });
    }

    protected onValueChanged() {
        this.valueChanged.next(this.templateForm.get('value').value);
    }
}
