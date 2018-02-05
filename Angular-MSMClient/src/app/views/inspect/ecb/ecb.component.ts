import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ecb',
  templateUrl: './ecb.component.html',
  styleUrls: ['./ecb.component.scss']
})
export class EcbComponent {
  
// lineChart
public lineChartData: Array<any> = [
  {data: [65, 59, 80, 81, 56, 55, 40], label: 'Log'},
  {data: [28, 48, 40, 19, 86, 27, 90], label: 'Target'},
];
public lineChartLabels: Array<any> = ['January', 'February', 'March', 'April', 'May', 'June', 'July'];
public lineChartOptions: any = {
  animation: false,
  responsive: true
};
// public lineChartColours: Array<any> = [
//   { // grey
//     backgroundColor: 'rgba(148,159,177,0.2)',
//     borderColor: 'rgba(148,159,177,1)',
//     pointBackgroundColor: 'rgba(148,159,177,1)',
//     pointBorderColor: '#fff',
//     pointHoverBackgroundColor: '#fff',
//     pointHoverBorderColor: 'rgba(148,159,177,0.8)'
//   },
//   { // dark grey
//     backgroundColor: 'rgba(77,83,96,0.2)',
//     borderColor: 'rgba(77,83,96,1)',
//     pointBackgroundColor: 'rgba(77,83,96,1)',
//     pointBorderColor: '#fff',
//     pointHoverBackgroundColor: '#fff',
//     pointHoverBorderColor: 'rgba(77,83,96,1)'
//   },
//   { // grey
//     backgroundColor: 'rgba(148,159,177,0.2)',
//     borderColor: 'rgba(148,159,177,1)',
//     pointBackgroundColor: 'rgba(148,159,177,1)',
//     pointBorderColor: '#fff',
//     pointHoverBackgroundColor: '#fff',
//     pointHoverBorderColor: 'rgba(148,159,177,0.8)'
//   }
// ];
public lineChartLegend = true;
public lineChartType = 'line';
// events
public chartClicked(e: any): void {
  console.log(e);
}

public chartHovered(e: any): void {
  console.log(e);
}
}
