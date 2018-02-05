import { SmartGridPage } from './app.po';

describe('SmartGrid App', function() {
  let page: SmartGridPage;

  beforeEach(() => {
    page = new SmartGridPage();
  });

  it('should open the app successfully', () => {
    page.navigateTo();
  });
});
