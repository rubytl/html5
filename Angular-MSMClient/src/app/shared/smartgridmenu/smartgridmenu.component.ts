import { Component } from '@angular/core';

@Component({
  selector: 'smartgridmenu-selector',
  templateUrl: './smartgridmenu.component.html',
  styleUrls: ['./smartgridmenu.component.css']
})
export class SmartGridMenuComponent {

  public disabled: boolean = false;
  public status: { isopen: boolean } = { isopen: false };

  public toggled(open: boolean): void {
    console.log('Dropdown is now: ', open);
  }

  public toggleDropdown($event: MouseEvent): void {
    $event.preventDefault();
    $event.stopPropagation();
    this.status.isopen = !this.status.isopen;
  }
}
