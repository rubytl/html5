import { HttpClient } from '@angular/common/http';
import { ProgressActions } from '../actions';
import { DialogOption } from '../models';
import { msmHelper } from '../helpers';
import { BsModalService } from 'ngx-bootstrap/modal';
import 'rxjs/Rx';
import 'rxjs/add/operator/catch';
// put this next to the other RxJs operator imports
// With the shareReplay operator in place, we would no longer
// fall into the situation where we have accidental multiple HTTP requests.
import 'rxjs/add/operator/shareReplay';

export abstract class BaseService {

  constructor(private http: HttpClient, private progressAct: ProgressActions, private modelService: BsModalService) {
  }

  // Open the confirm diaglog
  protected openNotificationDialog(error) {
    let message = error.error.message ? error.error.message : error.error ? error.error : error.message;
    let settings = { title: 'Error', message: message };
    msmHelper.openNotificationDialog(this.modelService, settings);
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
    this.openNotificationDialog(error);
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

  protected put(url, data, headers): Promise<any> {
    this.startProgress();
    return this.http
      .put(url, data, { headers: headers })
      .toPromise()
      .then(res => {
        this.finishProgress();
        return res;
      })
      .catch(error => this.handleError(error));
  }

  protected delete(url, data, headers): Promise<any> {
    this.startProgress();
    return this.http
      .delete(url + data, { headers: headers })
      .toPromise()
      .then(res => {
        this.finishProgress();
        return res;
      })
      .catch(error => this.handleError(error));
  }

}