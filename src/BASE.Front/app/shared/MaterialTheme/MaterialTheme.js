import { createMuiTheme } from '@material-ui/core/styles';

const theme = createMuiTheme({
  palette: {
    common: {
      black: 'rgba(26, 26, 26, 1)',
      white: '#fff'
    },
    background: {
      paper: '#fff',
      default: '#fafafa'
    },
    primary: {
      light: 'rgba(255, 102, 139, 1)',
      main: 'rgba(215, 46, 94, 1)',
      dark: 'rgba(159, 0, 53, 1)',
      contrastText: '#fff'
    },
    secondary: {
      light: 'rgba(88, 178, 213, 1)',
      main: 'rgba(19, 130, 164, 1)',
      dark: 'rgba(0, 85, 117, 1)',
      contrastText: '#fff'
    },
    error: {
      light: '#e57373',
      main: '#f44336',
      dark: '#d32f2f',
      contrastText: '#fff'
    },
    text: {
      primary: 'rgba(26, 26, 26, 1)',
      secondary: 'rgba(0, 0, 0, 0.54)',
      disabled: 'rgba(0, 0, 0, 0.38)',
      hint: 'rgba(0, 0, 0, 0.38)'
    }
  }
});

function Pallete() {
  return theme;
}

export default Pallete;
