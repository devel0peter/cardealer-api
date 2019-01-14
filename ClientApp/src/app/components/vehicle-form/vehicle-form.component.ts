import { Component, OnInit } from '@angular/core';
import { VehicleService } from '../../services/vehicle.service';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  makes : any[];
  vehicle : any = {};
  models: any[];
  features: any[];

  constructor(private vehicleService: VehicleService) { }

  ngOnInit() {
    this.getMakes();
    this.getFeatures();
    
  }

  onMakeChange() {
    let selectedMake = this.makes.find(make => make.id == this.vehicle.make);
    this.models = selectedMake ? selectedMake.models : [];
  }

  private getMakes() {
    this.vehicleService.getMakes().subscribe(makes => {
      this.makes = makes;
    });
  }

  private getFeatures() {
    this.vehicleService.getFeatures().subscribe(features => {
      this.features = features;
    });
  }
}
