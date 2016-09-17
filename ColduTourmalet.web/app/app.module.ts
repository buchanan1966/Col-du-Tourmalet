import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component'
import { HomeComponent } from './home.component';
import { Page1Component } from './page1.component';
import { routing } from './app.routing';

@NgModule({
    imports: [
        BrowserModule,
        routing],
    declarations: [
        AppComponent,
        HomeComponent,
        Page1Component],
    bootstrap: [AppComponent]
})
export class AppModule { }

// These changes were required to get the example to run.
