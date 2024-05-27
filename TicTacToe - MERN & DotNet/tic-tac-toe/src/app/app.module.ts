import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'; // Import HttpClientModule here
import { AppComponent } from './app.component';
import { GameComponent } from './game/game.component'; // Import GameComponent
import { SquareComponent } from './square/square.component';

@NgModule({
  declarations: [
    AppComponent,
    GameComponent,
    SquareComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule // Add HttpClientModule here
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
