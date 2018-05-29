import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { Subject } from 'rxjs/Subject';
import { BsModalRef } from 'ngx-bootstrap/modal';
export class MsmDialogComponent implements OnInit, OnDestroy {
    private onClose: Subject<any>;
    constructor(private bsModalRef: BsModalRef) {
    }

    ngOnInit() {
        this.onClose = new Subject();
        this.onComponentInit();
    }

    ngOnDestroy() {
        this.onClose.unsubscribe();
    }

    onClick(content) {
        this.onClose.next(content);
        this.bsModalRef.hide();
    }

    protected onComponentInit() {
    }
}
