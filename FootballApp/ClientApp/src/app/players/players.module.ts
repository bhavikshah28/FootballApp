import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';


import { PlayersRoutingModule } from './players-routing.module';
import { ListComponent } from './list/list.component';
import { EditComponent } from './edit/edit.component';
import { DetailsComponent } from './details/details.component';
import { CreateComponent } from './create/create.component';





@NgModule({
  declarations: [ListComponent, EditComponent, DetailsComponent, CreateComponent],
  imports: [
    CommonModule,
    PlayersRoutingModule
  ]
})
export class PlayersModule { }
