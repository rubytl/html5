import { HttpClient } from '@angular/common/http';
import { ProgressActions } from '../actions';
import { DialogOption } from '../models';
import { msmHelper } from '../helpers';
import { BsModalService } from 'ngx-bootstrap/modal';

export abstract class BaseService {

  constructor(private http: HttpClient, public progressAct: ProgressActions, private modelService: BsModalService) {
  }

  // Open the confirm diaglog
  protected openConfirmDialog(error) {
    let settings = { title: 'Error', message: error.message };
    var modalRef = msmHelper.openConfirmDialog(this.modelService, settings);
    modalRef.content.onClose.subscribe(result => {
      console.log('results', result);
    });
  }

  protected startProgress() {
    this.progressAct.updateProgress(true);
  }

  protected finishProgress() {
    this.progressAct.updateProgress(false);
  }

  protected handleError(error) {
    this.finishProgress();

    // Show the model dialog here
    this.openConfirmDialog(error);
  }

  protected post(url, data, headers): Promise<any> {
    this.startProgress();
    return this.http
      .post(url, data, { headers: headers })
      .toPromise()
      .then(res => {
        this.finishProgress();
        return res;
      })
      .catch(error => this.handleError(error));
  }

  protected get(url, headers): Promise<any> {
    this.startProgress();
    return this.http
      .get(url, { headers: headers })
      .toPromise()
      .then(res => {
        this.finishProgress();
        return res;
      })
      .catch(error => this.handleError(error));
  }
}