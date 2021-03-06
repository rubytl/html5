import { Component, OnChanges, OnDestroy, Input, Output, EventEmitter } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

export class MsmTemplateComponent implements OnDestroy, OnChanges {
    @Output() valueChanged = new EventEmitter<any>();
    @Input() value: any;
    @Input() id: any;
    @Input() name: any;
    @Input() templateList: any;
    templateForm: FormGroup;
    constructor(private fb: FormBuilder) {
        this.templateForm = this.fb.group({ value: null });
    }

    ngOnDestroy() {
        this.valueChanged.unsubscribe();
    }

    ngOnChanges() {
        this.rebuildForm();
    }

    rebuildForm() {
        this.templateForm.patchValue({
            value: this.value
        });
    }

    protected onValueChanged() {
        this.valueChanged.next({
            name: this.name, id: this.id,
            value: this.templateForm.get('value').value
        });
    }
}
