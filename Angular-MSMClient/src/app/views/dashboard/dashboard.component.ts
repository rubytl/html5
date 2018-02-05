import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  templateUrl: 'dashboard.component.html'
})
export class DashboardComponent {
  menuChoice: string;
  chooseMode(mode: string) {
    this.menuChoice = mode;
  }
}
