export abstract class BaseService {

  constructor() { }

  protected handleError(error): Promise<any> {
    var applicationError = error.headers.get('Application-Error');

    // either applicationError in header or model error in body
    if (applicationError) {
      return Promise.reject(applicationError);
    }

    return Promise.reject(error);
  }
}