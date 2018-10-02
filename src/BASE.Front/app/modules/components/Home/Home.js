import React from 'react';

import classes from './Home.scss';
import card from 'assets/images/Group.png';
import AddIcon from '@material-ui/icons/Add';

const Home = () => {
  return (
    <div>
      <div className={classes.sectionWrapper}>
        <div className={classes.titleWrapper}>
          <h2>Cards</h2>
          <AddIcon />
        </div>
        <div className={classes.cardsWrapper}>
          <img src={card} className="mr-2" />{' '}
          <img src={card} className="mr-2" />{' '}
          <img src={card} className="mr-2" />
        </div>
      </div>
    </div>
  );
};

export default Home;
