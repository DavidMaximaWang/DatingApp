import { Photo } from './photo';

export interface User {
  id: number;
  username: string;
  gender: string;
  age: string;
  knownAs: string;
  created: string;
  photoUrl: string;
  lastActive: string;
  city: string;
  country: string;
  introduction?: string;
  lookingfor?: string;
  interests?: string;
  photos?: Photo[];
}
