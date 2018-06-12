import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgRedux } from 'ng2-redux';
import { Subject } from 'rxjs/Subject';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { msmHelper } from '../../helpers';

export class MsmDialogComponent implements OnInit, OnDestroy {
    private onClose: Subject<any>;
    constructor(private bsModalRef: BsModalRef, private modelService: BsModalService) {
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

    // Open the confirm diaglog
    protected openNotificationDialog(tittle, message) {
        let settings = { title: tittle, message: message };
        msmHelper.openNotificationDialog(this.modelService, settings);
    }
}
