import { Component, OnInit } from '@angular/core';
import { MakeService } from '../../services/make.service';
import { FeatureService } from '../../services/feature.service';

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

  constructor(
    private makeService: MakeService,
    private featureService: FeatureService,
  ) { }

  ngOnInit() {
    this.getMakes();
    this.getFeatures();
    
  }

  onMakeChange() {
    let selectedMake = this.makes.find(make => make.id == this.vehicle.make);
    this.models = selectedMake ? selectedMake.models : [];
  }

  private getMakes() {
    this.makeService.getMakes().subscribe(makes => {
      this.makes = makes;
    });
  }

  private getFeatures() {
    this.featureService.getFeatures().subscribe(features => {
      this.features = features;
    });
  }
}
