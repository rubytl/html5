import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { Subject } from 'rxjs/Subject';
import { BsModalRef } from 'ngx-bootstrap/modal';
export class MsmDialogComponent implements OnInit, OnDestroy {
    private onClose: Subject<boolean>;
    constructor(private bsModalRef: BsModalRef) {
    }

    ngOnInit() {
        this.onClose = new Subject();
    }

    ngOnDestroy() {
        this.onClose.unsubscribe();
    }

    onClick(content) {
        this.onClose.next(content);
        this.bsModalRef.hide();
    }
}