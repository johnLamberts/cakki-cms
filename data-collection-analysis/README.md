
# Functional Specification: Visual SaaS CMS

## I. The Security & Authentication Foundation (The Fortress)

*Goal: To provide banking-grade identity protection and session management that operates invisibly to the user while securing the application against modern web threats.*

### 1. Backend-for-Frontend (BFF) Proxy Architecture

* **Invisible Token Management:** The system manages all authentication tokens (Access & Refresh) strictly on the server side. The browser client never receives, stores, or processes these sensitive keys, eliminating the risk of theft via local storage XSS attacks.
* **Encrypted Session Cookies:** User sessions are maintained via high-security cookies (HttpOnly, Secure, SameSite=Strict). These cookies act only as a reference ID, meaning even if stolen, they contain no user credentials or persistent keys.
* **Automatic Token Rotation:** The system automatically refreshes the user's access privileges in the background without interrupting their workflow. If a session becomes suspicious, the refresh cycle is broken, instantly locking the intruder out.
* **State-Changing Protection (CSRF):** Every "write" action (saving a page, publishing a post) requires a unique, one-time cryptographic validation token, ensuring that commands can only originate from your legitimate user interface.

### 2. Advanced Identity & Access Control

* **Centralized Login Portal:** A unified, branded login experience that supports standard email/password as well as enterprise Single Sign-On (SSO).
* **Adaptive Multi-Factor Authentication (MFA):**
* **Time-Based OTP:** Integration with standard authenticator apps (Google/Microsoft Authenticator).
* **Biometric Hardware Support (FIDO2):** Native support for logging in via FaceID, TouchID, or YubiKeys for phishing-resistant security.


* **Session Governance ("The Kill Switch"):**
* **Active Device Dashboard:** Users and Admins can view a live list of all devices currently logged into an account (e.g., "Chrome on Windows - Last active 2m ago").
* **Remote Revocation:** One-click ability to terminate a specific session or force a global logout for a compromised user.


* **Intelligent Threat Detection:**
* **Impossible Travel:** The system flags logins occurring in two distant geographic locations within an impossible timeframe.
* **Device Fingerprinting:** Recognizes previously used devices; new devices may trigger an automatic step-up verification (email confirmation or MFA) before access is granted.



---

## II. The "Unique" Visual Editor (The Page Composer)

*Goal: To bridge the gap between design freedom and structured content, allowing users to build complex, responsive layouts without writing code.*

### 1. The Interactive Infinity Canvas

* **Component-Driven Drag & Drop:** Users build pages by dragging pre-coded, functional blocks (e.g., "Hero Section," "Pricing Table," "Newsletter Form") rather than generic HTML boxes. This ensures design consistency and code quality.
* **In-Context Direct Editing:** Text modification happens directly on the canvas ("What You See Is What You Edit"). Users click a headline to type and double-click an image to open the media picker.
* **Responsive Viewport Simulation:**
* **Live Device Toggles:** Instant switching between Mobile (375px), Tablet (768px), and Desktop (1440px) views.
* **Device-Specific Overrides:** Changes made in "Mobile View" (e.g., reducing font size) are automatically saved as mobile-only styles, leaving the Desktop version untouched.



### 2. The Design Panel (Visual CSS Control)

* **Advanced Layout Engine:**
* **Flexbox Controls:** Visual alignment tools (Start, Center, End, Space-Between) for arranging items in rows or columns.
* **Grid Systems:** Ability to define complex 2D layouts (rows and columns) visually.


* **The Box Model Controller:** A precise input system for adjusting Margins (outside spacing), Padding (inside spacing), and Borders via drag-handles or numeric inputs.
* **Typography & Visual Effects:**
* **Type Controls:** Granular control over Font Family, Weight, Line Height, Letter Spacing, and Text Transform (Uppercase/Lowercase).
* **Styling:** Interface for adding Drop Shadows, Opacity layers, Corner Radius, and Background Blurs.



### 3. Dynamic Data Binding & Repeating

* **Visual Data Connection:** A "Connect to Data" interface allows users to link any UI element (e.g., a text block or image) to a dynamic field in the database (e.g., `Product Title` or `Author Photo`).
* **Repeater Lists:** A powerful "Collection List" component. Users design a single item (e.g., one blog card), and the system automatically repeats that design for every item in the connected database table.

### 4. Component System (Symbols)

* **Master Components:** The ability to save a group of elements (e.g., a Navbar or Footer) as a "Symbol."
* **Global Updates:** Editing a Master Component instantly updates every instance of that component across the entire website.
* **Overrides:** Ability to change specific content (e.g., the button text) inside a specific instance of a Symbol without breaking the Master design.

---

## III. The Data & Schema Engine (The Headless Core)

*Goal: To provide a flexible, user-defined database structure that powers the visual experience via high-performance APIs.*

### 1. The Schema Builder

* **Visual Content Modeler:** A drag-and-drop interface for defining new data structures (Content Types).
* **Single Types:** For unique pages (e.g., "Homepage," "About Us").
* **Collection Types:** For repeating content (e.g., "Blogs," "Products," "Events").


* **Field Library:** A rich set of data inputs including:
* **Basic:** Text, Rich Text, Number, Boolean, Date/Time.
* **Advanced:** JSON Objects, Color Pickers, Map Locations.
* **Relational:** Reference fields (Link an "Author" to a "Post").


* **Data Integrity Rules:** Configuration options for "Required" fields, unique values (e.g., specific SKUs), and regex pattern matching to ensure clean data entry.

### 2. Automated API Generation

* **Instant Endpoints:** Upon saving a Content Type, the system automatically provisions secure REST and GraphQL endpoints for that data.
* **Smart Query Parameters:** Built-in capabilities for developers to fetch data precisely:
* **Filtering:** `?category=tech`
* **Sorting:** `?sort=publishedDate:desc`
* **Pagination:** `?limit=10&offset=20`
* **Field Selection:** `?fields=title,slug,coverImage` (to reduce payload size).



### 3. Digital Asset Management (DAM)

* **Centralized Media Library:** A unified repository for all uploaded files (Images, Videos, PDFs) with folder-based organization and search capabilities.
* **Intelligent Processing:**
* **Auto-Optimization:** Images are automatically compressed and converted to modern formats (WebP/AVIF) upon upload for faster loading.
* **Smart Focal Point:** Users can set a "Focal Point" on an image so that critical parts (e.g., a face) are never cropped out, regardless of the screen size.



---

## IV. Advanced Governance (RBAC & Workflow)

*Goal: To provide granular control over user permissions and ensure content quality through structured approval processes.*

### 1. Granular Permission Matrix (RBAC)

* **Custom Role Creator:** The ability to define bespoke roles (e.g., "SEO Specialist," "Junior Designer") beyond the standard Admin/Editor presets.
* **Capability Toggles:** A fine-grained checklist for each role, controlling specific actions:
* *Content:* Can Create, Can Edit, Can Delete, Can Publish.
* *Design:* Can Edit Text, Can Move Layout, Can Change Global Styles.
* *System:* Can Manage Users, Can View Billing.



### 2. The "Locking" System

* **Visual Layout Locking:** Admins can mark specific sections (like the Header, Footer, or Legal Disclaimers) as "Locked." Locked sections cannot be moved, deleted, or restyled by lower-level users, protecting the brand integrity.
* **Field-Level Security:** The ability to set visibility rules on specific data fields. For example, a "Commission Rate" field on a Partner profile can be hidden from "Content Editors" but visible to "Admins."

### 3. Workflow Pipelines & History

* **Publishing Workflow:** A structured status system for content entries:
* *Draft:* Private, work-in-progress.
* *Pending Review:* Locked for editing, awaiting approval.
* *Scheduled:* Set to go live automatically at a future date/time.
* *Published:* Live on the public API.


* **Time Travel (Versioning):**
* **Auto-Save History:** The system creates a new version snapshot on every save.
* **Diff View:** Ability to compare two versions side-by-side to see exactly what changed.
* **One-Click Rollback:** Instantly restore any previous version of a page or content entry if a mistake is made.



### 4. Audit Logging

* **Immutable Activity Record:** A permanent, searchable log of every significant action taken within the system.
* **Traceability:** Logs capture the "Who" (User ID), "What" (Action: Deleted Post), "When" (Timestamp), and "Where" (IP Address), ensuring full accountability for security and compliance.
