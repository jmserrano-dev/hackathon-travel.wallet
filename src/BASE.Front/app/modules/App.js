import React, { Component } from 'react';
import { MuiThemeProvider } from '@material-ui/core/styles';
import HeaderApp from './components/Shared/Header/Header';
import Pallete from '../shared/MaterialTheme/MaterialTheme';
import Home from './components/Home/Home';

import '@styles/import.scss';
import {} from './app.scss';

export class App extends Component {
  render() {
    return (
      <MuiThemeProvider theme={Pallete}>
        <header>
          <HeaderApp />
        </header>
        <main>
            <Home></Home>
            </main>
      </MuiThemeProvider>
    );
  }
}
