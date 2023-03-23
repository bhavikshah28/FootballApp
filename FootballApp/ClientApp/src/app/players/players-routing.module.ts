import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListComponent } from './list/list.component';
import { EditComponent } from './edit/edit.component';
import { DetailsComponent } from './details/details.component';
import { CreateComponent } from './create/create.component';



const routes: Routes = [
  { path: 'players', redirectTo: 'players/list' },
  { path: 'players/list', component: ListComponent },
  { path: 'players/:playerId/edit', component: EditComponent },
  { path: 'players/:playerId/details', component: DetailsComponent },
  { path: 'players/create', component: CreateComponent },
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PlayersRoutingModule { }
