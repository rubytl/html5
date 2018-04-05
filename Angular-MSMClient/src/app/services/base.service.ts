import { HttpClient } from '@angular/common/http';
import { ProgressActions } from '../actions';

export abstract class BaseService {

  constructor(private http: HttpClient, private progressAct: ProgressActions) {
  }

  protected handleError(error): Promise<any> {
    this.progressAct.updateProgress(false);
    // Show the model dialog here
    var applicationError = error.headers.get('Application-Error');

    // either applicationError in header or model error in body
    if (applicationError) {
      return Promise.reject(applicationError);
    }

    return Promise.reject(error);
  }

  protected post(url, data, headers): Promise<any> {
    this.progressAct.updateProgress(true);
    return this.http
      .post(url, data, { headers: headers })
      .toPromise()
      .then(res => {
        this.progressAct.updateProgress(false);
        return res;
      })
      .catch(error => this.handleError(error));
  }

  protected get(url, headers): Promise<any> {
    this.progressAct.updateProgress(true);
    return this.http
      .post(url, { headers: headers })
      .toPromise()
      .then(res => {
        this.progressAct.updateProgress(false);
      })
      .catch(error => this.handleError(error));
  }
}