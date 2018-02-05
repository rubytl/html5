import { Component } from '@angular/core';

@Component({
  selector: 'app-energy-single',
  templateUrl: './energy.component.html',
  styleUrls: ['./energy.component.scss']
})
export class EnergySingleComponent {

  // lineChart
  public lineChartData: Array<any> = [
    { data: [65, 59, 80, 81, 56, 55, 40], label: 'Log' },
    { data: [28, 48, 40, 19, 86, 27, 90], label: 'Target' },
  ];
  public lineChartLabels: Array<any> = ['January', 'February', 'March', 'April', 'May', 'June', 'July'];
  public lineChartOptions: any = {
    animation: false,
    responsive: true
  };
  public lineChartLegend = true;
  public lineChartType = 'line';

  // Pie
  pieChartLabels: string[] = ['Generator', 'Wind', 'Solar'];
  pieChartData: number[] = [100, 20, 50];
  pieChartType = 'pie';

  // events
  public chartClicked(e: any): void {
    console.log(e);
  }

  public chartHovered(e: any): void {
    console.log(e);
  }
}
