using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugsBunny
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen lapiz = new Pen(Color.Black, 1.75f);
            SolidBrush whiteBrush = new SolidBrush(Color.FromArgb(255, 255, 255));
            SolidBrush grayBrush = new SolidBrush(Color.FromArgb(181, 187, 191));
            SolidBrush orangeBrush = new SolidBrush(Color.FromArgb(245, 164, 46));
            SolidBrush blackBrush = new SolidBrush(Color.FromArgb(0, 0, 0));

            e.Graphics.DrawLine(lapiz, 30, 30, 100, 100);

            // cola
            Point[] colaP1 =
            {
                new Point(494, 511), new Point(487, 509), new Point(477, 503),
                new Point(465, 486), new Point(463, 469), new Point(459, 454),
                new Point(459, 446), new Point(462, 440), new Point(465, 427),
                new Point(467, 444), new Point(470, 456), new Point(472, 472),
                new Point(475, 482), new Point(490, 490),
            };

            // cola
            Point[] colaP2 =
            {
                new Point(468, 450), new Point(468, 437), new Point(465, 433),
                new Point(465, 426), new Point(474, 429), new Point(488, 435),
                new Point(498, 442), new Point(506, 449), new Point(510, 467),
                new Point(501, 493), new Point(489, 499), new Point(480, 488),
                new Point(474, 476), new Point(469, 463),
            };

            // base torso
            Point[] mainBase = {
                new Point(537, 628), new Point(515, 646), new Point(495, 652),
                new Point(486, 651), new Point(473, 636), new Point(466, 631),
                new Point(446, 618), new Point(470, 618), new Point(491, 611),
                new Point(491, 600), new Point(487, 554), new Point(487, 512),
                new Point(489, 499), new Point(524, 463), new Point(538, 435),
                new Point(543, 433), new Point(551, 432), new Point(559, 422),
                new Point(568, 405), new Point(573, 390), new Point(550, 395),
                new Point(531, 399), new Point(519, 406), new Point(533, 431),
                new Point(530, 439), new Point(528, 442), new Point(522, 444),
                new Point(517, 442), new Point(516, 441), new Point(500, 429),
                new Point(482, 414), new Point(477, 400), new Point(477, 396),
                new Point(489, 386), new Point(531, 363), new Point(560, 348),
                new Point(570, 348), new Point(555, 333), new Point(522, 311),
                new Point(494, 285), new Point(492, 264), new Point(489, 247),
                new Point(492, 235), new Point(483, 220), new Point(477, 200),
                new Point(477, 189), new Point(479, 171), new Point(491, 126),
                new Point(499, 81), new Point(503, 50), new Point(505, 48),
                new Point(512, 55), new Point(529, 103), new Point(532, 121),
                new Point(532, 145), new Point(527, 171), new Point(522, 183),
                new Point(514, 205), new Point(511, 216), new Point(519, 208),
                new Point(523, 191), new Point(531, 175), new Point(545, 156),
                new Point(568, 122), new Point(583, 87), new Point(591, 67),
                new Point(596, 62), new Point(601, 67), new Point(603, 104),
                new Point(592, 157), new Point(574, 185), new Point(560, 198),
                new Point(538, 223), new Point(551, 227), new Point(557, 226),
                new Point(564, 233), new Point(587, 269), new Point(585, 313),
                new Point(601, 339), new Point(617, 341), new Point(632, 349),
                new Point(651, 359), new Point(678, 369), new Point(703, 348),
                new Point(713, 351), new Point(728, 352), new Point(717, 374),
                new Point(697, 396), new Point(681, 401), new Point(667, 400),
                new Point(642, 393), new Point(622, 389), new Point(605, 441),
                new Point(570, 488), new Point(585, 507), new Point(605, 543),
                new Point(616, 561), new Point(616, 573), new Point(596, 595),
                new Point(587, 603), new Point(616, 605), new Point(607, 613),
                new Point(596, 629), new Point(592, 631), new Point(583, 632),
                new Point(574, 632), new Point(535, 618), new Point(531, 610),
                new Point(530, 604), new Point(552, 588), new Point(578, 565),
                new Point(576, 554), new Point(567, 539), new Point(553, 525),
                new Point(541, 518), new Point(521, 518), new Point(521, 537),
                new Point(524, 588), new Point(537, 628)
            };

            // mano derecha
            Point[] manoDerecha = {
                new Point(489, 499), new Point(480, 499), new Point(470, 503),
                new Point(457, 512), new Point(449, 518), new Point(441, 523),
                new Point(433, 526), new Point(431, 524), new Point(427, 518),
                new Point(427, 511), new Point(431, 506), new Point(440, 497),
                new Point(447, 494), new Point(463, 491), new Point(458, 486),
                new Point(458, 483), new Point(459, 475), new Point(456, 469),
                new Point(456, 466), new Point(453, 461), new Point(451, 457),
                new Point(451, 449), new Point(456, 445), new Point(466, 448),
                new Point(470, 452), new Point(473, 455), new Point(475, 460),
                new Point(475, 469), new Point(474, 474), new Point(479, 477),
                new Point(479, 474), new Point(482, 470), new Point(501, 463),
                new Point(502, 458), new Point(498, 454), new Point(488, 457),
                new Point(485, 458), new Point(479, 455), new Point(474, 446),
                new Point(473, 437), new Point(476, 431), new Point(482, 428),
                new Point(486, 428), new Point(490, 437), new Point(492, 444),
                new Point(501, 443), new Point(509, 438), new Point(518, 445),
                new Point(521, 445), new Point(530, 441), new Point(533, 431),
                new Point(533, 431), new Point(539, 435), new Point(540, 440),
                new Point(544, 450), new Point(545, 461), new Point(541, 470),
                new Point(520, 488), new Point(499, 498), new Point(490, 498),
            };


            Point[] pataDerecha = {
                new Point(535, 628), new Point(537, 635), new Point(523, 652),
                new Point(498, 671), new Point(471, 683), new Point(433, 689),
                new Point(428, 685), new Point(412, 686), new Point(398, 679),
                new Point(392, 672), new Point(386, 663), new Point(386, 654),
                new Point(391, 637), new Point(402, 624), new Point(421, 617),
                new Point(448, 619), new Point(461, 627), new Point(475, 637),
                new Point(484, 647), new Point(488, 652), new Point(494, 653),
                new Point(511, 647), new Point(535, 628),
            };

            Point[] pataIzquierda = {
                new Point(535, 619), new Point(564, 630), new Point(585, 634),
                new Point(592, 630), new Point(606, 617), new Point(619, 602),
                new Point(640, 594), new Point(661, 596), new Point(671, 600),
                new Point(684, 612), new Point(689, 620), new Point(688, 633),
                new Point(680, 639), new Point(675, 646), new Point(665, 650),
                new Point(652, 651), new Point(639, 654), new Point(622, 656),
                new Point(586, 647), new Point(555, 638), new Point(540, 632),
                new Point(536, 621),
            };

            Point[] barriga = {
                new Point(521, 518), new Point(518, 508), new Point(518, 502),
                new Point(518, 494), new Point(519, 487), new Point(528, 476),
                new Point(540, 466), new Point(546, 461), new Point(553, 456),
                new Point(558, 451), new Point(564, 447), new Point(571, 439),
                new Point(579, 432), new Point(584, 424), new Point(588, 416),
                new Point(592, 407), new Point(594, 395), new Point(595, 380),
                new Point(594, 370), new Point(590, 360), new Point(585, 350),
                new Point(579, 340), new Point(569, 331), new Point(558, 331),
                new Point(548, 332), new Point(538, 332), new Point(529, 332),
                new Point(521, 331), new Point(513, 329), new Point(505, 328),
                new Point(511, 334), new Point(502, 332), new Point(497, 328),
                new Point(495, 324), new Point(492, 320), new Point(492, 328),
                new Point(487, 323), new Point(485, 319), new Point(485, 313),
                new Point(485, 308), new Point(481, 312), new Point(481, 303),
                new Point(484, 296), new Point(489, 290), new Point(495, 282),
                new Point(502, 278), new Point(510, 275), new Point(517, 273),
                new Point(525, 273), new Point(533, 272), new Point(540, 272),
                new Point(548, 272), new Point(554, 272), new Point(562, 271),
                new Point(568, 272), new Point(574, 272), new Point(583, 273),
                new Point(588, 273), new Point(587, 267), new Point(585, 261),
                new Point(581, 257), new Point(579, 254), new Point(582, 253),
                new Point(588, 252), new Point(595, 252), new Point(603, 252),
                new Point(608, 252), new Point(614, 253), new Point(619, 256),
                new Point(623, 260), new Point(627, 267), new Point(628, 274),
                new Point(623, 269), new Point(626, 277), new Point(625, 281),
                new Point(625, 289), new Point(621, 281), new Point(619, 288),
                new Point(616, 292), new Point(612, 300), new Point(607, 305),
                new Point(601, 312), new Point(595, 317), new Point(595, 323),
                new Point(595, 329), new Point(598, 335), new Point(602, 339),
                new Point(607, 343), new Point(612, 346), new Point(615, 348),
                new Point(618, 351), new Point(622, 354), new Point(626, 359),
                new Point(629, 366), new Point(632, 370), new Point(635, 376),
                new Point(638, 381), new Point(639, 386), new Point(640, 395),
                new Point(641, 403), new Point(641, 409), new Point(640, 416),
                new Point(638, 423), new Point(635, 432), new Point(632, 441),
                new Point(629, 448), new Point(626, 454), new Point(624, 459),
                new Point(620, 465), new Point(616, 473), new Point(610, 479),
                new Point(606, 483), new Point(601, 489), new Point(596, 494),
                new Point(591, 499), new Point(585, 505), new Point(578, 509),
                new Point(574, 512), new Point(571, 515), new Point(566, 518),
                new Point(559, 521), new Point(553, 523), new Point(545, 521),
                new Point(537, 517), new Point(529, 518),
            };

            Point[] orejaDerecha = {
                new Point(502, 224), new Point(499, 219), new Point(495, 210),
                new Point(492, 198), new Point(493, 188), new Point(493, 177),
                new Point(496, 165), new Point(498, 154), new Point(501, 142),
                new Point(503, 131), new Point(505, 122), new Point(506, 112),
                new Point(508, 106), new Point(509, 99), new Point(512, 88),
                new Point(513, 77), new Point(517, 85), new Point(518, 91),
                new Point(521, 96), new Point(522, 105), new Point(523, 113),
                new Point(525, 125), new Point(524, 135), new Point(523, 145),
                new Point(522, 152), new Point(521, 161), new Point(519, 168),
                new Point(517, 175), new Point(514, 184), new Point(512, 192),
                new Point(509, 200), new Point(507, 210), new Point(505, 216),
            };

            Point[] orejaIzquierda = {
                new Point(528, 218), new Point(528, 211), new Point(530, 204),
                new Point(534, 197), new Point(538, 189), new Point(541, 183),
                new Point(547, 175), new Point(555, 163), new Point(561, 154),
                new Point(566, 147), new Point(570, 140), new Point(575, 133),
                new Point(579, 128), new Point(582, 123), new Point(587, 115),
                new Point(589, 110), new Point(595, 101), new Point(595, 106),
                new Point(595, 111), new Point(594, 117), new Point(593, 121),
                new Point(593, 127), new Point(592, 132), new Point(589, 142),
                new Point(586, 150), new Point(584, 156), new Point(580, 163),
                new Point(576, 170), new Point(573, 173), new Point(568, 179),
                new Point(564, 183), new Point(560, 187), new Point(556, 191),
                new Point(552, 196), new Point(548, 199), new Point(545, 202),
                new Point(541, 205), new Point(538, 208), new Point(535, 212),
            };

            Point[] zanahoria = {
                new Point(650, 305), new Point(649, 303), new Point(646, 301),
                new Point(648, 295), new Point(647, 291), new Point(651, 288),
                new Point(654, 285), new Point(658, 283), new Point(663, 282),
                new Point(668, 281), new Point(672, 282), new Point(675, 282),
                new Point(678, 281), new Point(682, 281), new Point(686, 281),
                new Point(692, 281), new Point(701, 281), new Point(711, 281),
                new Point(723, 281), new Point(731, 281), new Point(736, 281),
                new Point(740, 281), new Point(744, 282), new Point(752, 284),
                new Point(756, 288), new Point(758, 294), new Point(757, 301),
                new Point(756, 306), new Point(754, 313), new Point(746, 317),
                new Point(738, 318), new Point(729, 316), new Point(721, 316),
                new Point(713, 316), new Point(706, 316), new Point(697, 312),
                new Point(685, 311), new Point(680, 310), new Point(677, 307),
                new Point(671, 307), new Point(664, 307), new Point(658, 306),
            };

            Point[] zanahoriap2 = {
                new Point(759, 314), new Point(759, 321), new Point(759, 330),
                new Point(758, 338), new Point(757, 343), new Point(754, 342),
                new Point(748, 341), new Point(744, 343), new Point(741, 347),
                new Point(738, 351), new Point(736, 355), new Point(735, 360),
                new Point(739, 365), new Point(745, 365), new Point(742, 369),
                new Point(741, 373), new Point(740, 378), new Point(739, 384),
                new Point(739, 389), new Point(742, 394), new Point(747, 393),
                new Point(754, 389), new Point(753, 394), new Point(753, 399),
                new Point(752, 403), new Point(752, 407), new Point(753, 412),
                new Point(755, 417), new Point(760, 418), new Point(766, 416),
                new Point(771, 410), new Point(772, 402), new Point(773, 395),
                new Point(772, 388), new Point(771, 383), new Point(775, 387),
                new Point(780, 387), new Point(783, 381), new Point(782, 374),
                new Point(780, 368), new Point(779, 365), new Point(782, 365),
                new Point(785, 366), new Point(785, 361), new Point(784, 356),
                new Point(781, 348), new Point(777, 345), new Point(773, 343),
                new Point(769, 343), new Point(769, 338), new Point(769, 327),
                new Point(769, 321), new Point(767, 312), new Point(766, 307),
                new Point(764, 304), new Point(760, 300), new Point(758, 307),
            };

            Point[] manoIzquierda = {
                new Point(702, 344), new Point(703, 340), new Point(702, 338),
                new Point(699, 335), new Point(695, 328), new Point(694, 326),
                new Point(690, 324), new Point(687, 320), new Point(686, 316),
                new Point(687, 311), new Point(689, 307), new Point(694, 305),
                new Point(697, 302), new Point(701, 298), new Point(703, 293),
                new Point(701, 290), new Point(699, 287), new Point(697, 283),
                new Point(695, 281), new Point(691, 283), new Point(683, 284),
                new Point(680, 281), new Point(680, 276), new Point(682, 271),
                new Point(686, 266), new Point(690, 262), new Point(697, 260),
                new Point(702, 259), new Point(707, 265), new Point(709, 268),
                new Point(713, 267), new Point(719, 264), new Point(723, 265),
                new Point(728, 263), new Point(732, 261), new Point(738, 257),
                new Point(745, 255), new Point(749, 252), new Point(754, 248),
                new Point(760, 245), new Point(767, 246), new Point(769, 253),
                new Point(765, 263), new Point(760, 268), new Point(753, 272),
                new Point(748, 273), new Point(744, 274), new Point(740, 278),
                new Point(735, 278), new Point(732, 280), new Point(737, 286),
                new Point(740, 291), new Point(740, 297), new Point(732, 303),
                new Point(727, 302), new Point(723, 299), new Point(720, 304),
                new Point(717, 307), new Point(717, 308), new Point(714, 309),
                new Point(710, 312), new Point(706, 315), new Point(713, 317),
                new Point(721, 318), new Point(725, 316), new Point(733, 316),
                new Point(738, 322), new Point(739, 327), new Point(740, 332),
                new Point(735, 338), new Point(733, 342), new Point(732, 350),
                new Point(721, 352), new Point(718, 351), new Point(710, 350),
            };

            Point[] ojoDerechoP1 =
            {
                new Point(539, 272), new Point(536, 269), new Point(530, 265),
                new Point(524, 257), new Point(521, 253), new Point(518, 248),
                new Point(516, 243), new Point(513, 236), new Point(513, 232),
                new Point(520, 231), new Point(525, 234), new Point(532, 237),
                new Point(537, 242), new Point(542, 247), new Point(545, 251),
                new Point(550, 257), new Point(553, 262), new Point(556, 269),
                new Point(556, 271),
            };

            Point[] ojoIzquierdoP1 = { 
                new Point(585, 266), new Point(581, 262), new Point(575, 257),
                new Point(572, 254), new Point(570, 251), new Point(568, 248), 
                new Point(563, 241), new Point(562, 237), new Point(564, 236),
                new Point(568, 237), new Point(571, 240), new Point(575, 244),
                new Point(578, 247), new Point(579, 248),  new Point(581, 250),
                new Point(584, 257),
            };

            Point[] ojoDerechoP2 = {
                new Point(539, 274), new Point(537, 270), new Point(536, 266),
                new Point(537, 264), new Point(536, 264), new Point(538, 263),
                new Point(541, 263), new Point(544, 266), new Point(545, 269),
                new Point(546, 268), new Point(546, 270), new Point(546, 272),
            };

            Point[] ojoIzquierdoP2 = { 
                new Point(575, 255), new Point(578, 252), new Point(581, 252),
                new Point(583, 255), new Point(582, 256), new Point(584, 256),
                new Point(584, 259), new Point(585, 264), new Point(583, 262),
                new Point(581, 260),new Point(579, 261),  new Point(578, 258),
            };

            Point[] nariz = {
                new Point(580, 274), new Point(584, 270), new Point(587, 270),
                new Point(588, 274), new Point(585, 276),
            };

            Point[] diente = {
                new Point(577, 287), new Point(577, 292), new Point(578, 303),
                new Point(584, 306), new Point(591, 306), new Point(597, 301),
                new Point(598, 293), new Point(598, 278), new Point(596, 280),
                new Point(593, 281), new Point(589, 280), new Point(588, 283),
                new Point(584, 285), new Point(580, 285), new Point(577, 284),
            };

            // bigotes
            Point[] b1 = {
                new Point(596, 265), new Point(599, 258), new Point(605, 251),
                new Point(610, 245), new Point(615, 239), new Point(624, 230),
            };
            Point[] b2 = {
                new Point(594, 272), new Point(603, 262), new Point(609, 257),
                new Point(617, 251), new Point(623, 246), new Point(638, 236),
            };
            Point[] b3 = {
                new Point(595, 272), new Point(609, 262), new Point(619, 256),
                new Point(640, 248),
            };
            Point[] b4 = {
                new Point(573, 280), new Point(559, 278), new Point(544, 277),
                new Point(526, 277), new Point(508, 277), new Point(472, 281),
            };
            Point[] b5 = {
                new Point(572, 280), new Point(549, 282), new Point(528, 284),
                new Point(496, 289), new Point(470, 297),
            };
            Point[] b6 = {
                new Point(572, 283), new Point(550, 286), new Point(527, 291),
                new Point(508, 297), new Point(484, 309),
            };
            Point[] b7 = {
                new Point(573, 284), new Point(555, 289), new Point(540, 294),
                new Point(522, 304),
            };

            // detallado

            Point[] mb1 = { // mainBase
                new Point(565, 268), new Point(568, 265), new Point(570, 264),
            };
            Point[] mb2 = { // mainBase
                new Point(570, 270), new Point(574, 267), new Point(578, 265),
            };
            Point[] mb3 = { // mainBase
                new Point(509, 243), new Point(505, 236), new Point(504, 228),
                new Point(504, 222), new Point(509, 219), new Point(518, 223),
            };
            Point[] mb4 = { // mainBase
                new Point(551, 232), new Point(552, 228), new Point(556, 226),
                new Point(560, 229),
            };
            Point[] mb5 = { // mainBase
                new Point(510, 216), new Point(514, 212), new Point(521, 205),
                new Point(517, 215), new Point(516, 217), new Point(522, 211),
                new Point(528, 208), new Point(535, 207), new Point(529, 212),
                new Point(522, 218), new Point(530, 217), new Point(535, 215),
                new Point(526, 221),
            };
            Point[] mb6 = { // MainBase
                new Point(571, 348), new Point(576, 351), new Point(581, 356),
            };

            Point[] bar1 = { // barriga
                new Point(625, 393), new Point(626, 385), new Point(625, 378),
                new Point(621, 372), new Point(617, 366),
            };
            Point[] bar2 = { // boca
                new Point(577, 297), new Point(572, 295),
            };
            Point[] bar3 = { // boca
                new Point(599, 289), new Point(602, 286),
            };

            Point[] m1 = { // mano derecha
                new Point(513, 442), new Point(515, 447), new Point(520, 450),
                new Point(525, 450), new Point(530, 449), new Point(534, 446),
                new Point(538, 440), new Point(538, 437), new Point(537, 432),
                new Point(534, 432),
            };
            Point[] m2 = { // mano derecha
                new Point(520, 452), new Point(517, 455), new Point(515, 459),
                new Point(515, 466),
            };
            Point[] m3 = { // mano derecha
                new Point(489, 498), new Point(485, 492), new Point(481, 485),
                new Point(480, 479), new Point(480, 479),
            };
            Point[] m4 = { // mano derecha
                new Point(497, 482), new Point(502, 480), new Point(507, 478),
                new Point(511, 473), new Point(511, 469), new Point(510, 465),
                new Point(507, 464), new Point(502, 462), new Point(497, 462),
            };
            Point[] m5 = { // mano derecha
                new Point(481, 496), new Point(475, 494), new Point(469, 492),
                new Point(463, 489),
            };
            Point[] m6 = { // mano izquierda 
                new Point(709, 268), new Point(710, 272), new Point(709, 274),
                new Point(713, 277), new Point(718, 276), new Point(723, 277),
                new Point(727, 281), new Point(725, 287), new Point(721, 291),
                new Point(718, 287), new Point(714, 284), new Point(708, 283),
                new Point(705, 286), new Point(703, 292), new Point(699, 287),
            };
            Point[] m7 = { // mano izquierda 
                new Point(725, 264), new Point(728, 271), new Point(729, 275),
                new Point(731, 280),
            };
            Point[] m8 = { // mano izquierda 
                new Point(728, 334), new Point(727, 329), new Point(724, 324),
                new Point(717, 319), new Point(711, 316),
            };
            Point[] m9 = { // mano izquierda 
                new Point(732, 341), new Point(728, 342), new Point(722, 344),
                new Point(717, 345), new Point(712, 344), new Point(707, 341),
                new Point(705, 338),
            };
            Point[] m10 = { // mano izquierda
                new Point(722, 302), new Point(722, 299), new Point(722, 294), new Point(721, 291),
            };

            Point[] p1 = { // pie derecho
                new Point(427, 684), new Point(423, 680), new Point(421, 673),
                new Point(421, 668), new Point(424, 660), new Point(429, 653),
                new Point(437, 646),
            };
            Point[] p2 = { // pie derecho
                new Point(393, 674), new Point(391, 666), new Point(391, 658),
                new Point(394, 651), new Point(398, 643), new Point(403, 637),
                new Point(410, 633),
            };
            Point[] p3 = { // pie izquierdo
                new Point(651, 651), new Point(654, 644), new Point(654, 639),
                new Point(653, 634), new Point(651, 628), new Point(646, 623),
                new Point(640, 620),
            };
            Point[] p4 = { // pie izquierdo
                new Point(678, 639), new Point(679, 636), new Point(679, 631),
                new Point(678, 624), new Point(676, 619), new Point(673, 616),
                new Point(669, 611), new Point(661, 607),
            };

            Point[] d1 = { // diente
                new Point(591, 282), new Point(591, 284), new Point(591, 289),
                new Point(591, 293),
            };

            Point[] z1 = { // zanahoria
                new Point(676, 282), new Point(679, 285), new Point(682, 290),
            };
            Point[] z2 = {
                new Point(674, 308), new Point(677, 303),
            };
            Point[] z3 = {
                new Point(726, 316), new Point(730, 313), new Point(732, 310),
            };
            Point[] z4 = {
                new Point(753, 353), new Point(755, 349), new Point(761, 349),
                new Point(764, 351), new Point(766, 357), new Point(769, 355),
                new Point(769, 352), new Point(769, 343),
            };
            Point[] z5 = {
                new Point(764, 328), new Point(764, 323), new Point(764, 315),
                new Point(763, 311), new Point(762, 308), new Point(758, 304),
            };

            // cola
            e.Graphics.FillPolygon(whiteBrush, colaP1);
            e.Graphics.FillPolygon(grayBrush, colaP2);
            e.Graphics.DrawPolygon(lapiz, colaP1);
            e.Graphics.DrawPolygon(lapiz, colaP2);

            // base torso
            e.Graphics.FillPolygon(grayBrush, mainBase);
            e.Graphics.DrawPolygon(lapiz, mainBase);

            // pata derecha
            e.Graphics.FillPolygon(whiteBrush, pataDerecha);
            e.Graphics.DrawPolygon(lapiz, pataDerecha);

            // pata izquierda
            e.Graphics.FillPolygon(whiteBrush, pataIzquierda);
            e.Graphics.DrawPolygon(lapiz, pataIzquierda);

            // barriga
            e.Graphics.FillPolygon(whiteBrush, barriga);
            e.Graphics.DrawPolygon(lapiz, barriga);

            // oreja derecha
            e.Graphics.FillPolygon(whiteBrush, orejaDerecha);
            e.Graphics.DrawPolygon(lapiz, orejaDerecha);

            // oreja izquierda
            e.Graphics.FillPolygon(whiteBrush, orejaIzquierda);
            e.Graphics.DrawPolygon(lapiz, orejaIzquierda);

            // zanahoria
            e.Graphics.FillPolygon(orangeBrush, zanahoria);
            e.Graphics.DrawPolygon(lapiz, zanahoria);
            e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(98, 165, 34)), zanahoriap2);
            e.Graphics.DrawPolygon(lapiz, zanahoriap2);

            // mano derecha
            e.Graphics.FillPolygon(whiteBrush, manoDerecha);
            e.Graphics.DrawPolygon(lapiz, manoDerecha);

            // mano izquierda
            e.Graphics.FillPolygon(whiteBrush, manoIzquierda);
            e.Graphics.DrawPolygon(lapiz, manoIzquierda);

            // ojo derecho p1
            e.Graphics.FillPolygon(whiteBrush, ojoDerechoP1);
            e.Graphics.DrawPolygon(lapiz, ojoDerechoP1);

            // ojo izquierdo p1
            e.Graphics.FillPolygon(whiteBrush, ojoIzquierdoP1);
            e.Graphics.DrawPolygon(lapiz, ojoIzquierdoP1);

            // ojo derecho p2
            e.Graphics.FillPolygon(blackBrush, ojoDerechoP2);

            // ojo izauierdo p2
            e.Graphics.FillPolygon(blackBrush, ojoIzquierdoP2);

            // nariz
            e.Graphics.FillPolygon(new SolidBrush(Color.FromArgb(231, 153, 129)), nariz);
            e.Graphics.DrawPolygon(lapiz, nariz);

            // diente
            e.Graphics.FillPolygon(whiteBrush, diente);
            e.Graphics.DrawPolygon(lapiz, diente);

            // bigotes
            e.Graphics.DrawCurve(lapiz, b1);
            e.Graphics.DrawCurve(lapiz, b2);
            e.Graphics.DrawCurve(lapiz, b3);
            e.Graphics.DrawCurve(lapiz, b4);
            e.Graphics.DrawCurve(lapiz, b5);
            e.Graphics.DrawCurve(lapiz, b6);
            e.Graphics.DrawCurve(lapiz, b7);

            // detallado mainBase
                // mainBase
                e.Graphics.DrawCurve(new Pen(Color.Black, 1), mb1);
                e.Graphics.DrawCurve(new Pen(Color.Black, 1), mb2);
                e.Graphics.DrawCurve(lapiz, mb3);
                e.Graphics.DrawCurve(lapiz, mb4);
                e.Graphics.DrawCurve(lapiz, mb5);
                e.Graphics.DrawCurve(lapiz, mb6);

                // barriga
                e.Graphics.DrawCurve(lapiz, bar1);
                e.Graphics.DrawCurve(lapiz, bar2);
                e.Graphics.DrawCurve(lapiz, bar3);

                // manos
                e.Graphics.DrawCurve(lapiz, m1);
                e.Graphics.DrawCurve(lapiz, m2);
                e.Graphics.DrawCurve(lapiz, m3);
                e.Graphics.DrawCurve(lapiz, m4);
                e.Graphics.DrawCurve(lapiz, m5);
                e.Graphics.DrawCurve(lapiz, m6);
                e.Graphics.DrawCurve(lapiz, m7);
                e.Graphics.DrawCurve(lapiz, m8);
                e.Graphics.DrawCurve(lapiz, m9);
                e.Graphics.DrawCurve(lapiz, m10);

                // pies
                e.Graphics.DrawCurve(lapiz, p1);
                e.Graphics.DrawCurve(lapiz, p2);
                e.Graphics.DrawCurve(lapiz, p3);
                e.Graphics.DrawCurve(lapiz, p4);

                // diente
                e.Graphics.DrawCurve(lapiz, d1);

                // zanahoria
                e.Graphics.DrawLine(lapiz, 651, 305, 654, 302);
                e.Graphics.DrawLine(lapiz, 654, 302, 660, 303);
                e.Graphics.DrawLine(lapiz, 660, 303, 660, 298);
                e.Graphics.DrawLine(lapiz, 660, 298, 665, 294);
                e.Graphics.DrawLine(lapiz, 665, 294, 662, 293);
                e.Graphics.DrawLine(lapiz, 662, 293, 662, 287);
                e.Graphics.DrawLine(lapiz, 662, 287, 659, 288);
                e.Graphics.DrawLine(lapiz, 659, 288, 656, 284);
                e.Graphics.DrawCurve(lapiz, z1);
                e.Graphics.DrawCurve(lapiz, z2);
                e.Graphics.DrawCurve(lapiz, z3);
                e.Graphics.DrawCurve(lapiz, z4);
                e.Graphics.DrawCurve(lapiz, z5);
        } // fin del evento Paint


        private void PictureBox_Click(object sender, EventArgs e)
        {
            Graphics g = PictureBox.CreateGraphics();
            Pen lapiz = new Pen(Color.Purple, 2);
            
            MouseEventArgs me = (MouseEventArgs)e;
            Point co = me.Location;
            textBox1.Text = me.Location.X.ToString();
            textBox2.Text = me.Location.Y.ToString();

            g.DrawRectangle(lapiz, new Rectangle(me.Location.X, me.Location.Y, 2, 2));
            textBox3.Text += String.Format("new Point({0}, {1}), ", textBox1.Text, textBox2.Text);
            
        } // fin del evento Click
    } // fin del Form
} // fin del namespace
